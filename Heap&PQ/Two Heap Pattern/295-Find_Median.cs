

//The median is the middle value in an ordered integer list. If the size of the list is even, there is no middle value, and the median is the mean of the two middle values.


public class MedianFinder {
    PriorityQueue<int, int> lowerHalf = new PriorityQueue<int, int>(); 
    PriorityQueue<int, int> upperHalf = new PriorityQueue<int, int>();

    public MedianFinder() {
       
    }
    
    public void AddNum(int num) {
        if(upperHalf.Count == 0 || num < upperHalf.Peek()){
            lowerHalf.Enqueue(num,-num);
        }else{
            upperHalf.Enqueue(num,num);
        }
        Balance();
    }
    
    public double FindMedian() {
        if(upperHalf.Count == lowerHalf.Count){
            return (lowerHalf.Peek() + upperHalf.Peek()) / 2.0;
        }
        return lowerHalf.Peek();
    }

    public void Balance(){
        if(lowerHalf.Count < upperHalf.Count){
            int val = upperHalf.Dequeue();
            lowerHalf.Enqueue(val,-val);
        }
        if(lowerHalf.Count > upperHalf.Count + 1){
            int val = lowerHalf.Dequeue();
            upperHalf.Enqueue(val, val);
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */




 