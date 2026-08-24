int Calculator(int num1, int num2){
Console.WriteLine("Simvolu daxil et: ");
char operation = Convert.ToChar(Console.ReadLine());
while(operation != '+' && operation != '-' && operation != '*' && operation != '/'){
Console.WriteLine("Enter Valid sign! Simvolu daxil et: ");
operation = Convert.ToChar(Console.ReadLine());}
switch (operation)
{
    case '+':
        return(num1+num2);
    case '-':
        return(num1-num2);
    case '*':
        return(num1*num2);
    case '/':
        return(num1/num2);

}
return 0;
}
Console.WriteLine(Calculator(34, 23));