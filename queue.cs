using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter
{
    public class Queue//queue class 
    {
        int front, rear, size;
        int capacity;
        int[] array;
        //queue constructor
        /*
         * to initialize attributes
         */
        public Queue(int capacity)
        {
            this.capacity = capacity;
            rear = 0;
            front = 0;
            size = 0;
            array = new int[this.capacity];
        }
        //check que is full or not
        public Boolean isFull(Queue queue)
        {
            return (queue.size == queue.capacity);
        }
        //check queue is empty
        public Boolean isEmpty(Queue queue)
        {
            return (queue.size == 0);
        }
        /*add last 
         * check queue is full then return 0
         * if que not full then add itome in queue
         * increse rear and size
         */
        public void enqueue(int itome)
        {
            if (isFull(this))
            {
                return;
            }
            else
            {
                array[this.rear] = itome;
                this.rear = this.rear + 1;
                this.size = size + 1;
            }
        }
        /*remove first
         * queue is empty then return 0
         * if no then remove itome
         * by frount increase position and itom remove by garbage callector
         */
        public int dequeue()
        {
            if (isEmpty(this))
            {
                return 0;
            }
            else
            {


                int itome = this.array[this.front];
                this.front = this.front + 1;
                this.size = size - 1;
                return itome;
            }
        }
        public void display()
        {
            while (front != rear)
            {
                Console.WriteLine(array[front]);
                front += 1;
            }
        }
    }
}

