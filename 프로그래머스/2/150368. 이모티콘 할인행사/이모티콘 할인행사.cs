using System;

public class Solution {
    public int[] discount;
    public int[] discountPercent = {10,20,30,40};
    public int count = 0;
    public int price = 0;
    public int[] solution(int[,] users, int[] emoticons) {
        int[] answer = new int[2];
        discount = new int[emoticons.Length];
        
        Dfs(0, users, emoticons);
        
        answer[0] = count;
        answer[1] = price;
        return answer;
    }
    
    public void Dfs(int depth, int[,] users, int[] emoticons){
        if(depth == emoticons.Length){
            Find(users, emoticons);
            return;
        }
        for(int i = 0; i < 4; i++){
            discount[depth] = discountPercent[i];
            Dfs(depth + 1, users, emoticons);
        }
    }
    
    public void Find(int[,] users, int[] emoticons){
        int sum = 0;
        int total = 0;
        
        for(int i = 0; i < users.GetLength(0); i++){
            int expense = 0;
            int rate = users[i,0];
            int max = users[i,1];
            
            for (int j = 0; j < discount.Length; j++)
            {
                if (discount[j] >= rate)
                {
                    expense += emoticons[j] - emoticons[j] * discount[j] / 100;
                } 
                if(expense >= max){
                    sum++;
                    expense = 0;
                    break;
                }
            }
            total += expense;   
        }
        
        if(sum > count){
            count = sum;
            price = total;
        }
        else if(sum == count){
            price = Math.Max(total, price);
        }
    }
}