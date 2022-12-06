//int age=Int32.Parse(Console.ReadLine());
// int age=Convert.ToInt32(Console.ReadLine());
// if(age>18) {
//     Console.WriteLine("Adult");
// }
// else {
//     Console.WriteLine("Not Adult");
// }



// int x=Int32.Parse(Console.ReadLine());
// if(x%2==0) {
//     Console.WriteLine("Even Number");
// }
// else {
//     Console.WriteLine("Odd Number");
// }


// int a=Int32.Parse(Console.ReadLine());
// int b=Convert.ToInt32(Console.ReadLine());
// if(a==b) {
//       Console.WriteLine("a is equal to b");
// }
// else if(a>b) {
//     Console.WriteLine("a is greater than b");
// }
// else {
//     Console.WriteLine("a is smaller than b");
// }


// int button=Int32.Parse(Console.ReadLine());
// if(button==1){
//     Console.WriteLine("Hii");
// }
// else if(button==2){
//     Console.WriteLine("Hello");
// }
// else if(button==3){
//     Console.WriteLine("Namaste");
// }
// else{
//     Console.WriteLine("Invalid Number");
// }


// int button=Int32.Parse(Console.ReadLine());
// switch(button){
//     case 1:Console.WriteLine("Hii");
//     break;
//     case 2:Console.WriteLine("Hello");
//     break;
//     case 3:Console.WriteLine("Namaste");
//     break;
//     default:Console.WriteLine("Invalid Number");
//     break;
// }



// for(int i=0;i<=10;i++)
// {
//     Console.WriteLine(i);
// }


// int i=0;
// while(i<11){
//     Console.WriteLine(i);
//     i++;
// }

// int i=0;
// do{
//     Console.WriteLine(i);
//     i++;
// }while(i<11);



// 

// int n=Int32.Parse(Console.ReadLine());

// for(int i=1;i<11;i++)
// {
//     Console.WriteLine(n*i);
// }



// int n=Int32.Parse(Console.ReadLine());
// int m=Int32.Parse(Console.ReadLine());
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=m;j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }


// int n=4;
// int m=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=m;j++){
//         if(i==1 ||j==1 ||i==n ||j==m){
//             Console.Write("*");
//         }
//             else{
//            Console.Write(" ");
//             }

//             }

// Console.WriteLine();
        
    
// }


// int n=Int32.Parse(Console.ReadLine());
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=i;j++){
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }


// int n=Int32.Parse(Console.ReadLine());
// for(int i=n;i>=1;i--){
//     for(int j=1;j<=i;j++){
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }




// int n=Int32.Parse(Console.ReadLine());
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=n-i;j++){
//         Console.Write(" ");
//     }
//     for(int j=1;j<=i;j++){
//         Console.Write("*");
//     }
//     Console.WriteLine();
//     }




// int n=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=i;j++){
//         Console.Write(j+" ");
//     }
//     Console.WriteLine();
// }


// int n=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=n-i+1;j++){
//         Console.Write(j);
//     }
//     Console.WriteLine();
// }





// int n=5;
// int number=1;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=i;j++){
//         Console.Write(number+" ");
//         number++;
//     }
//     Console.WriteLine();
// }



// int n=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=i;j++){
//         int sum=i+j;
//         if(sum%2==0){
//             Console.Write("1");
//         }else{
//             Console.Write("0");
//         }
//     }
//      Console.WriteLine();

// }


// int n=4;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=i;j++){
//         Console.Write("*");
//     }
//     int spaces=2*(n-i);
//     for(int j=1;j<=spaces;j++){
//         Console.Write(" ");
//     }

//         for(int j=1;j<=i;j++){
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }

//     for(int i=n;i>=1;i--){
//         for(int j=1;j<=i;j++){
//             Console.Write("*");
//         }
//         int spaces=2*(n-i);
//         for(int j=1;j<=spaces;j++){
//             Console.Write(" ");
//         }
//         for(int j=1;j<=i;j++){
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }



// int n=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=n-i;j++){
//         Console.Write(" ");
//     }
//     for(int j=1;j<=n;j++){
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }


// int n=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=n-i;j++){
//         Console.Write(" ");
//     }
//     for(int j=1;j<=i;j++){
//         Console.Write(i+ " ");
//     }
//     Console.WriteLine();
// }


// int n=5;
// for(int i=1;i<=n;i++){
//     for(int j=1;j<=n-i;j++){
//         Console.Write(" ");
//     }
//     for(int j=i;j>=1;j--){
//         Console.Write(j);
//     }
//     for(int j=2;j<=i;j++){
//         Console.Write(j);
//     }
//     Console.WriteLine();
// }



//  static int CalculateSum(int a,int b){
//     int sum=a+b;
//     return sum;
// }
// int a=Int32.Parse(Console.ReadLine());
// int b=Int32.Parse(Console.ReadLine());

// int sum=CalculateSum(a,b);
// Console.WriteLine(sum);



static int CalculateMult(int a,int b){
    int mult=a*b;
    return mult;
}
int a=Int32.Parse(Console.ReadLine());
int b=Int32.Parse(Console.ReadLine());

int mult=CalculateMult(a,b);
Console.WriteLine(mult);



