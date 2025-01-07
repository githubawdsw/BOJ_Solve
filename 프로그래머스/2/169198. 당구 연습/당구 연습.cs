using System;

public class Solution {
    public int[] solution(int m, int n, int startX, int startY, int[,] balls) {
        int[] answer = new int[balls.GetLength(0)];
        for(int i = 0; i < balls.GetLength(0); i++){
            int dis = int.MaxValue;
            
            if(startY == balls[i,1]){
                if(startX < balls[i,0])
                    dis = Math.Min(Distance(startX, startY, -balls[i,0], balls[i,1]), dis);
            }
            else
                dis = Math.Min(Distance(startX, startY, -balls[i,0], balls[i,1]), dis);
            
            if(startX == balls[i,0]){
                if(startY < balls[i,1])
                    dis = Math.Min(Distance(startX, startY, balls[i,0], -balls[i,1]), dis);
            }
            else
                dis = Math.Min(Distance(startX, startY, balls[i,0], -balls[i,1]), dis);
            
            if(startY == balls[i,1]){
                if(startX > balls[i,0])
                    dis = Math.Min(Distance(startX, startY, 2 * m - balls[i,0], balls[i,1]), dis);    
            }
            else
                dis = Math.Min(Distance(startX, startY, 2 * m - balls[i,0], balls[i,1]), dis);    
            
            if(startX == balls[i,0]){
                if(startY > balls[i,1])
                    dis = Math.Min(Distance(startX, startY, balls[i,0], 2 * n - balls[i,1]), dis);
            }
            else
                dis = Math.Min(Distance(startX, startY, balls[i,0], 2 * n - balls[i,1]), dis);
            
            
            answer[i] = dis;
        }
        return answer;
    }
    
    public int Distance(int x1, int y1, int x2, int y2){
        return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
    }
}