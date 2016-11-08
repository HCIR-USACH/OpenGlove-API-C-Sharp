# OpenGlove-API-C-Sharp

## Example

```csharp
public HapticsGlove glove = new HapticsGlove();
glove.OpenPort("COM3", 9600);

public int[] pins = {10, 12};
public String[] valuesON = { "HIGH","LOW"};
public String[] valuesOFF = { "LOW", "LOW" };

glove.InitializeMotor(pins);
glove.InitializeMotor(pins, valuesON);

```
