using System;

public class Solution {
    public int Osuccess = 0;
    public int Xsuccess = 0;
    public int solution(string[] board) {
        
        char[,] TicTacToe = new char[3,3];
        int Ocount = 0;
        int Xcount = 0;
        for(int i = 0; i < board.Length; i++){
            for(int j = 0; j < board[i].Length; j++){
                TicTacToe[i,j] = board[i][j];
                if(board[i][j] == 'O')
                    Ocount++;
                else if(board[i][j] == 'X')
                    Xcount++;
            }
        }
        if(Xcount > Ocount || Ocount > Xcount + 1)
            return 0;
        
        Check(TicTacToe, 0, 0,  TicTacToe[0, 0]);
        
        for(int i = 1; i < 3; i++){
            Check(TicTacToe, 0, i,  TicTacToe[0, i]);
            Check(TicTacToe, i, 0,  TicTacToe[i, 0]);
        }
        
        if(Osuccess > 0 && Xsuccess > 0)
            return 0;
        if(Xsuccess > 0 && Ocount != Xcount)
            return 0;
        if(Osuccess == 1 && Ocount <= Xcount)
            return 0;
        
        return 1;
    }
    
    void Check(char[,] board, int x, int y, char shape){
        int[] dx = {0,1,1,1};
        int[] dy = {1,0,1,-1};
        
        for(int i = 0; i < 4; i++){
            int nx = x;
            int ny = y;
            
            int count = 1;
            while(count < 3){
                nx += dx[i];
                ny += dy[i];
                
                if(nx < 0 || ny < 0 || nx >= 3 || ny >= 3)
                    break;
                if(shape != board[nx,ny])
                    break;
                
                count++;
            }
            if(count == 3){
                if (shape == 'O')
                    Osuccess++;
                else if (shape == 'X')
                    Xsuccess++;
            }
        }
        return;
    }
}