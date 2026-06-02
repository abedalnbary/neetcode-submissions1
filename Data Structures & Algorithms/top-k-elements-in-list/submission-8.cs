public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
   Dictionary <int, int> res = new Dictionary <int, int>();
    List<int> []freq= new List <int>[nums.Length+1];
    for (int i=0;i<nums.Length+1; i++){
        freq[i]=new List<int>();
    }
    foreach(int num in nums){
        if(res.ContainsKey(num)){
            res[num]++;
        }else{
            res[num] = 1;
        }
    }
    foreach( var entry in res){
        freq[entry.Value].Add(entry.Key);
    }
    int [] res2=new int[k];
    int index=0;
    for(int i =freq.Length-1;i>0 && index<k;i--){
        foreach (int j in freq[i]){
            res2[index++]=j;
            if (index==k){
                return res2;
            }
        }
    }
    return res2;
    }
}
