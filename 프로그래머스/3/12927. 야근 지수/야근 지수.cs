using System;
public class Solution {
    public long solution(int n, int[] works) {
        PQ pq = new PQ();
        for(int i = 0; i < works.Length; i++){
            pq.Add(works[i]);
        }
        
        for(int i = 0; i < n; i++){
            var cur = pq.Top();
            
            if(pq.SIZE > 0)
            pq.Pop();
            if(cur - 1 > 0){
                pq.Add(cur - 1);
            }
                
        }
        
        long answer = 0;
        
        while(pq.SIZE > 0){
            long cur = (long)pq.Top();
            pq.Pop();
            answer += cur * cur;
        }
        
        return answer;
    }
    
}

public class PQ{
    int[] heap = new int[20005];
    
    int size = 0;
    public int SIZE{
        get{return size;}
        set{size = value;}
    }
    
    public void Add(int x){
        size++;
        heap[size] = x;
        int idx = size;
        
        while(idx != 1){
            int par = idx / 2;
            if(heap[par] >= heap[idx])
                break;
            
            int swap = heap[idx];
            heap[idx] = heap[par];
            heap[par] = swap;
            
            idx = par;
        }
        
    }
    
    public void Pop(){
        heap[1] = heap[size];
        heap[size--] = 0;
        int idx = 1;
        
        while(idx * 2 <= size){
            int left = idx * 2;
            int right = (idx * 2) + 1;
            int bigger = left;
            if(right <= size && heap[left] < heap[right])
                bigger = right;
            if(heap[idx] >= heap[bigger])
                break;
            
            int swap = heap[idx];
            heap[idx] = heap[bigger];
            heap[bigger] = swap;
            
            idx = bigger;
        }
    }
    public int Top(){
        return heap[1];
    }
}