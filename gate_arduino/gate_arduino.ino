#include <SoftwareSerial.h>
#include <Servo.h>


Servo SERVO1, SERVO2;

//------------bluetooth
#define Tx 7
#define Rx 6
#define MODE_1 '1'
#define MODE_2 '2'
#define RESET 'R'
#define READY 'D'
#define OPEN 'O'
#define CLOSE 'C'
#define GO 'G'
#define FINISH 'F'
SoftwareSerial mySerial(Rx, Tx); // RX, TX

//------------servo
#define SV1 10
#define SV2 9
#define handle_open_1 5
#define handle_open_2 160
#define handle_close_1 115
#define handle_close_2 55

//------------pin lazer
#define LAZER1 12
#define LAZER2 11
#define QUANG1 A1
#define QUANG2 A2

//
#define ALARM 3
//-----------define function

void open_gate ();
void close_gate ();

void reset_f ();

void ready_f ();

bool gogo = false;
void go_f ();

//return 0 => no one pass
//return 1 => gate 1 pass
//return 2 => gate 2 pass
//return 3 => both
uint8_t check_pass ();

void check_serial();

void runGate1();
void runGate2();

//-----------define variable
uint8_t mode = 0;
#define TIME_DISTANCE 10000
unsigned long timeDistance1, timeDistance2;
#define NOT_PASS 0
#define PASSED 1
#define FINISHED 2
uint8_t state1=NOT_PASS, state2=NOT_PASS;

unsigned long timeAlarm;

void setup()
{
  Serial.begin(9600);     // giao tiếp Serial với baudrate 9600
  mySerial.begin(9600);
  SERVO1.attach(SV1);
  SERVO2.attach(SV2);
  
  open_gate();
  //SERVO2.attach(SV2);
  pinMode(ALARM, OUTPUT);
  digitalWrite(ALARM, LOW);
  pinMode(LAZER1, OUTPUT);
  digitalWrite(LAZER1, HIGH);
  pinMode(LAZER2, OUTPUT);
  digitalWrite(LAZER2, HIGH);
  pinMode(QUANG1, INPUT);
  pinMode(QUANG2, INPUT);
}
 
void loop()
{
  check_serial();
  if (mode == 1 && gogo) {
    runGate1();
  }
  else if (mode == 2 && gogo) {
    runGate1();
    runGate2();
  }
  if (millis() - timeAlarm > 3000) {
    digitalWrite(ALARM, LOW);
  }
}

void open_gate () {
  Serial.println("open gate");
  SERVO1.write(handle_open_1);
  SERVO2.write(handle_open_2);
}
void close_gate () {
  Serial.println("close gate");
  SERVO1.write(handle_close_1);
  SERVO2.write(handle_close_2);
}
void go_f () {
  Serial.println("go go go");
  gogo = true;
  digitalWrite(ALARM, HIGH);
  timeAlarm = millis();
}
void reset_f () {
  Serial.println("reset");
  state1 = NOT_PASS;
  state2 = NOT_PASS;
  mode=0;
  gogo = false;
}
void ready_f () {
  Serial.println("ready");
  close_gate();
}
uint8_t check_pass () {
  uint8_t ret = 0;
  if (digitalRead(QUANG1)==HIGH) { //vat the di qua
    ret = 1;
    for (int i=0; i<1000; i++) {
      if (digitalRead(QUANG1)==LOW) { //vat the chua di qua
        Serial.println("Sai");
        ret=0;
        break;
      }
    }
  }
  if (mode==2) {
    if (digitalRead(QUANG2)==HIGH) {
      if (ret == 1) {
        ret = 3; //gia su 2 vat the deu qua
      } else {
        ret = 2;
      }
      for (int i=0; i<10; i++) {
        if (digitalRead(QUANG2)==LOW) {
          if(ret==3) {
            ret = 1;
          } else if (ret==2) {
            ret = 0;
          }
          break;
        }
      }
    }
  }
  return ret;
}
void check_serial () {
  if (mySerial.available() > 0) {
    char re_mess = mySerial.read();
    switch (re_mess) {
      case MODE_1:
        mode=1;
        Serial.println("MODE 1");
        break;
      case MODE_2:
        mode=2;
        Serial.println("MODE 2");
        break;
      case RESET:
        reset_f();
        break;
      case READY:
        ready_f();
        break;
      case OPEN:
        open_gate();
        break;
      case CLOSE:
        close_gate();
        break;
      case GO:
        go_f();
        break;
    }
  }
}

void runGate1() {
    if (state1 == NOT_PASS) {
      uint8_t val_check_pass = check_pass();
      if (val_check_pass==1 || val_check_pass==3) {
        mySerial.write('a');
        state1 = PASSED;
        timeDistance1=millis();
        Serial.println("1 PASS");
      }
    } else if (state1 == PASSED && (millis()-timeDistance1 > TIME_DISTANCE)) {
      uint8_t val_check_pass = check_pass();
      if (val_check_pass==1 || val_check_pass==3) {
        mySerial.write('a');
        state1 = FINISHED;
        Serial.println("1 Finish");
        digitalWrite(ALARM, HIGH);
        timeAlarm = millis();
      }
    }
}

void runGate2() {
    if (state2 == NOT_PASS) {
      uint8_t val_check_pass = check_pass();
      if (val_check_pass==2 || val_check_pass==3) {
        mySerial.write('b');
        state2 = PASSED;
        timeDistance1=millis();
        Serial.println("2 PASS");
      }
    } else if (state2 == PASSED && (millis()-timeDistance1 > TIME_DISTANCE)) {
      uint8_t val_check_pass = check_pass();
      if (val_check_pass==2 || val_check_pass==3) {
        mySerial.write('b');
        state2 = FINISHED;
        Serial.println("2 Finish");
        digitalWrite(ALARM, HIGH);
        timeAlarm = millis();
      }
    }
}
