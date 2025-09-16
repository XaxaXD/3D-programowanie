
using ObjectConsoleApp;

PointStruct pointStruct;
pointStruct.x = 5;
pointStruct.y = 10;

Console.WriteLine($"Punkt ma ({pointStruct.x}, {pointStruct.y}) ");

PointStruct secondPointStruct = pointStruct;
secondPointStruct.y = 20;

Console.WriteLine($"Pierwszy punkt ma ({pointStruct.x}, {pointStruct.y}) ");
Console.WriteLine($"Drugi punkt ma ({secondPointStruct.x}, {secondPointStruct.y}) ");

void ParapetrTestStruct_v1(PointStruct point)
{
    Console.WriteLine($"W ParapetrTestStruct_v1 punkt ma ({point.x}, {point.y}) ");
    point.x = 99;
    Console.WriteLine($"W ParapetrTestStruct_v1 punkt ma ({point.x}, {point.y}) ");
}

void ParapetrTestStruct_v2(ref PointStruct point)
{
    Console.WriteLine($"W ParapetrTestStruct_v2 punkt ma ({point.x}, {point.y}) ");
    point.x = 99;
    Console.WriteLine($"W ParapetrTestStruct_v2 punkt ma ({point.x}, {point.y}) ");
}

ParapetrTestStruct_v1(pointStruct);
Console.WriteLine($"Pierwszy punkt po wywołaniu ParapetrTestStruct_v1 ({pointStruct.x}, {pointStruct.y}) ");

ParapetrTestStruct_v2(ref pointStruct);
Console.WriteLine($"Pierwszy punkt po wywołaniu ParapetrTestStruct_v2 ({pointStruct.x}, {pointStruct.y}) ");