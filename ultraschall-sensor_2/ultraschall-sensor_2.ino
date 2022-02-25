// #include <NewPing.h>

#define TRIGGER 52
#define ECHO 30

#define TRIGGER_2 39
#define ECHO_2 40
#define MIN_DIST 4
#define MAX_DIST 30

float duration = 0.0;
float distance = 0.0;
float duration_2 = 0.0;
float distance_2 = 0.0;

// NewPing sonar(TRIGGER, ECHO, MAX_DIST);

void setup() {
  
  Serial.begin(9600);
  pinMode(TRIGGER, OUTPUT);
  pinMode(ECHO, INPUT);
  pinMode(TRIGGER_2, OUTPUT);
  pinMode(ECHO_2, INPUT);
}

void loop() {
//  delay(100);
//  unsigned int distanceCM = sonar.ping_cm();
//  Serial.print(distanceCM);
//  Serial.print("\n");

  // Messung 1. Ultraschallsensor
  digitalWrite(TRIGGER, LOW);
  delayMicroseconds(50);
  digitalWrite(TRIGGER, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGGER, LOW);
  duration = pulseIn(ECHO, HIGH);
  distance = (duration/2) * 0.03432;

 // Messung 2. Ultraschallsensor
  digitalWrite(TRIGGER_2, LOW);
  delayMicroseconds(50);
  digitalWrite(TRIGGER_2, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIGGER_2, LOW);
  duration_2 = pulseIn(ECHO_2, HIGH);
  distance_2 = (duration_2/2) * 0.03432;

  if(distance >= MAX_DIST && distance_2 >= MAX_DIST) {
    //Serial.print("Wert1:");
    //Serial.print("c1 ");
    //Serial.print("D");
    Serial.print(MAX_DIST);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(MAX_DIST);
    //Serial.print("\n");
    
  }
  else if(distance <= MIN_DIST && distance_2 >= MAX_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c2 ");
    //Serial.print("D");
    Serial.print(MIN_DIST);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(MAX_DIST);
    //Serial.print("\n");
  }
  else if(distance >= MAX_DIST && distance_2 <= MIN_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c3 ");
    //Serial.print("D");
    Serial.print(MAX_DIST);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(MIN_DIST);
    //Serial.print("\n");
  }
  else if(distance <= MIN_DIST && distance_2 <= MIN_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c4 ");
    //Serial.print("D");
    Serial.print(MIN_DIST);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(MIN_DIST);
    //Serial.print("\n");
  }
  else if (distance > MIN_DIST && distance_2 > MIN_DIST && distance < MAX_DIST && distance_2 < MAX_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c5 ");
    //Serial.print("D");
    Serial.print(distance);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(distance_2);
    //Serial.print("\n");
  }

   else if (distance > MIN_DIST && distance < MAX_DIST && distance_2 >= MAX_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c6 ");
    //Serial.print("D");
    Serial.print(distance);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(MAX_DIST);
    //Serial.print("\n");
  }

   else if (distance > MIN_DIST && distance < MAX_DIST && distance_2 <= MIN_DIST){
    //Serial.print("Wert1:");
    //Serial.println("c7 ");
    //Serial.print("D");
    Serial.print(distance);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(MIN_DIST);
    //Serial.print("\n");
  } 

  else if (distance_2 > MIN_DIST && distance_2 < MAX_DIST && distance >= MAX_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c8 ");
    //Serial.print("D");
    Serial.print(MAX_DIST);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(distance_2);
    //Serial.print("\n");
  } 

  else if (distance_2 > MIN_DIST && distance_2 < MAX_DIST && distance <= MIN_DIST){
    //Serial.print("Wert1:");
    //Serial.print("c9 ");
    //Serial.print("D");
    Serial.print(MIN_DIST);
    Serial.print(" ");
    //Serial.print("d");
    Serial.println(distance_2);
    //Serial.print("\n");
  } 
  
  delay(100);
  //delay(1000);


}
