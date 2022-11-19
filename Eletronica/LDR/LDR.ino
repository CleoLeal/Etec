// C++ code
//
int LDRValor = 0;

void setup()
{
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(A0, INPUT);
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
}

void loop()
{
  digitalWrite(11, LOW);
  digitalWrite(10, LOW);
  digitalWrite(10, LOW);

  LDRValor;

  LDRValor = analogRead(A0);
  Serial.println(LDRValor);
  if (LDRValor < 550) {
    digitalWrite(13, LOW);
    digitalWrite(12, LOW);
    digitalWrite(11, LOW);
    digitalWrite(10, LOW);
  } else {
    if (LDRValor < 600) {
      digitalWrite(13, HIGH);
      digitalWrite(12, LOW);
      digitalWrite(11, LOW);
      digitalWrite(10, LOW);
    } else {
      if (LDRValor < 700) {
        digitalWrite(13, HIGH);
        digitalWrite(12, HIGH);
        digitalWrite(11, LOW);
        digitalWrite(10, LOW);
      } else {
        if (LDRValor < 800) {
          digitalWrite(13, HIGH);
          digitalWrite(12, HIGH);
          digitalWrite(11, HIGH);
          digitalWrite(10, LOW);
        } else {
          digitalWrite(13, HIGH);
          digitalWrite(12, HIGH);
          digitalWrite(11, HIGH);
          digitalWrite(10, HIGH);
        }
      }
    }
  }
  delay(10); // Delay a little bit to improve simulation performance
}