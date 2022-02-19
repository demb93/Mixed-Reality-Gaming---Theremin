// #include <NewPing.h>

#define TRIGGER 52
#define ECHO 30
#define MIN_DIST 2
#define MAX_DIST 24

float duration = 0.0;
float distance = 0.0;

// NewPing sonar(TRIGGER, ECHO, MAX_DIST);

void setup() {
  
  Serial.begin(9600);
  pinMode(TRIGGER, OUTPUT);
  pinMode(ECHO, INPUT);

}

void loop() {
//  delay(100);
//  unsigned int distanceCM = sonar.ping_cm();
//  Serial.print(distanceCM);
//  Serial.print("\n");

  digitalWrite(TRIGGER, LOW);
  delayMicroseconds(50);
  digitalWrite(TRIGGER, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGGER, LOW);
  duration = pulseIn(ECHO, HIGH);
  distance = (duration/2) * 0.03432;

  if(distance >= MAX_DIST) {

    Serial.println(MAX_DIST);
    //Serial.print("\n");
    
  }
  else if(distance <= MIN_DIST){

    Serial.println(MIN_DIST);
    //Serial.print("\n");
  }
  else{
    Serial.println(distance);
    //Serial.print("\n");
  }  

  delay(100);


}
