 class MAIN  {
    public static void Main(string[] args) {
        //User should provide their own input to verify
        List<int> A = new List<int>(){ 4, 6, 3};
        foreach(int num in A){
          isPerfectNumber(num);
        }
    }
    public static void isPerfectNumber(int num){
        int total = 1;
        for(int i = 2; i * i <= num; i++){
            if(num % i == 0){
                if(i * i != num){
                    total += i + num / i;
                    continue;
                }
                total += i;
            }
        }
        if(total == num && num != 1){
            Console.WriteLine("YES");
            return;
        }
        Console.WriteLine("NO");
    }
}
