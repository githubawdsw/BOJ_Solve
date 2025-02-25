using System;

public class Solution {
    public long solution(int w, int h) {
        long answer = 0;
        for(int i = 1; i < h; i++){
            answer += (long)(h - i) * (long)w / (long)h;
        }
        return answer * 2;
    }
}