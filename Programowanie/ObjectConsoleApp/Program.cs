
using ObjectConsoleApp;
using System.Drawing;

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

//----------------------------------------------------------------------

PointClass firstPointClass = new PointClass();
firstPointClass.x = 5;
firstPointClass.y = 10;

Console.WriteLine($"firstPointClass ma ({firstPointClass.x}, {firstPointClass.y}) ");

PointClass secondPointClass = firstPointClass;
secondPointClass.x = 20;

Console.WriteLine($"firstPointClass ma ({firstPointClass.x}, {firstPointClass.y}) ");
Console.WriteLine($"secondPointClass ma ({secondPointClass.x}, {secondPointClass.y}) ");


void ParatertTestClass_v1(PointClass pc)
{
    Console.WriteLine($"W ParatertTestClass_v1 punkt ma ({pc.x}, {pc.y}) ");
    pc.x = 99;
    Console.WriteLine($"W ParatertTestClass_v1 punkt ma ({pc.x}, {pc.y}) ");
}

void ParatertTestClass_v2(PointClass pc)
{
    Console.WriteLine($"W ParatertTestClass_v2 punkt ma ({pc.x}, {pc.y}) ");
    pc = new PointClass();
    pc.x = 150;
    Console.WriteLine($"W ParatertTestClass_v2 punkt ma ({pc.x}, {pc.y}) ");
}

void ParatertTestClass_v3(ref PointClass pc)
{
    Console.WriteLine($"W ParatertTestClass_v3 punkt ma ({pc.x}, {pc.y}) ");
    pc = new PointClass();
    pc.x = 42;
    Console.WriteLine($"W ParatertTestClass_v3 punkt ma ({pc.x}, {pc.y}) ");
}


ParatertTestClass_v1(firstPointClass);
Console.WriteLine($"firstPointClass ({firstPointClass.x}, {firstPointClass.y}) ");

ParatertTestClass_v2(firstPointClass);
Console.WriteLine($"firstPointClass ({firstPointClass.x}, {firstPointClass.y}) ");

ParatertTestClass_v3(ref firstPointClass);
Console.WriteLine($"firstPointClass ({firstPointClass.x}, {firstPointClass.y}) ");