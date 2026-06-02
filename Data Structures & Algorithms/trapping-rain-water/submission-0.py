class Solution:
    def trap(self, height: List[int]) -> int:
        res=0
        l,r=0,len(height)-1
        Maxleft,MaxRigth=height[l],height[r]
        
        while(l<r):
            if (Maxleft<MaxRigth):
                l+=1
                Maxleft=max(height[l],Maxleft)
                res+=Maxleft-height[l]
            else:
                r-=1
                MaxRigth=max(MaxRigth,height[r])
                res+=MaxRigth-height[r]
        return res
                