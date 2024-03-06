using Extreme.Mathematics;

Console.WriteLine("Angle A: ");
float A = float.Parse(Console.ReadLine());
Console.WriteLine("Angle B: ");
float B = float.Parse(Console.ReadLine());;
Console.WriteLine("X1: ");
float X1 = float.Parse(Console.ReadLine());
Console.WriteLine("Y1: ");
float Y1 = float.Parse(Console.ReadLine());
Console.WriteLine("X2: ");
float X2 = float.Parse(Console.ReadLine());
Console.WriteLine("Y2: ");
float Y2 = float.Parse(Console.ReadLine());

AccuracyGoal accuracyGoal = AccuracyGoal.InheritRelative;

BigFloat tanA = BigFloat.Tan(A * BigFloat.GetPi(accuracyGoal)/180,accuracyGoal);
BigFloat tanB = BigFloat.Tan(B* BigFloat.GetPi(accuracyGoal)/180,accuracyGoal);

BigFloat Px = new BigFloat(1,accuracyGoal);
BigFloat Py = new BigFloat(1,accuracyGoal);


Px = BigFloat.Divide(BigFloat.Add(BigFloat.Multiply(tanA,X1),BigFloat.Add(BigFloat.Subtract(BigFloat.Multiply(tanB,X2),Y2),Y1)), BigFloat.Subtract(tanB,tanA));
Px = BigFloat.Round(Px, 40, RoundingMode.TowardsNearest);
Console.WriteLine("BigFloat Px: " + Px);

Py = BigFloat.Divide(BigFloat.Subtract(BigFloat.Add(BigFloat.Multiply(BigFloat.Multiply(tanA,tanB),BigFloat.Subtract(X2,X1) ),BigFloat.Multiply(tanB,Y1) ),BigFloat.Multiply(tanA,Y2) ),BigFloat.Subtract(tanB,tanA));
Py = BigFloat.Round(Py, 40, RoundingMode.TowardsNearest);
Console.WriteLine("BigFloat Py: " + Py);



