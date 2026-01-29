
int annualTrainingFee = int.Parse(Console.ReadLine());

double basketballSneakers = annualTrainingFee * 0.6;
double basketballUniform = basketballSneakers * 0.8;
double basketballBall = basketballUniform * 0.25;
double basketballAccessories = basketballBall * 0.2;

double totalCost = annualTrainingFee + basketballSneakers + basketballUniform + basketballBall + basketballAccessories;

Console.WriteLine(totalCost);
