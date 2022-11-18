namespace Maths;
public class  Complex {
    public int  real, imag;
    public Complex(int r , int i)
    { 
        real = r;
        imag = i;
   }
     
    // Function to perform operation By changing sign of integers

    public static Complex operator +(Complex c1,Complex c2)
    {
        Complex temp=new Complex(0,0);
        temp.real=c1.real  +c2.real;
        temp.imag = c1.imag +c2.imag;
        return temp;
    }

    public static Complex operator -(Complex c1,Complex c2)
    {
        Complex temp=new Complex(0,0);
        temp.real=c1.real  -c2.real;
        temp.imag = c1.imag-c2.imag;
        return temp;
    }

    public override string ToString()
    {
        return  this.real + "+ i"+this.imag;
    }
}

/**
*! +, -, !, ~, ++, – –	    unary operators take one operand and can be overloaded.
*! +, -, *, /, %	        Binary operators take two operands and can be overloaded
*! ==, !=, =	            Comparison operators can be overloaded.
*! &&, ||	                Conditional logical operators cannot be overloaded directly
*! +=, -+, *=, /=, %=, =	Assignment operators cannot be overloaded.
*/
