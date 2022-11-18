package com.example;

public class Stack implements Cloneable
    {
       public int size;
       public  int[] sArr;

        public Stack(int size)
        {
            this.sArr = new int[size];
            for(int i = 0; i < size; i++)
            {
                this.sArr[i] = i+9;
            }
            this.size = this.sArr.length;
        }

        public Object clone() throws CloneNotSupportedException
        {
            //Shallow Copy: only refernces are copied
            //Deep Copy:objects pointed by references are copied into new object
            Stack newCopyStack = new Stack(this.size);
            //newCopyStack.sArr = this.sArr;  //Shallow Copy
         
            System.arraycopy(this.sArr, 0, newCopyStack.sArr, 0, size);    //deep copy
            return newCopyStack;
        }
    }