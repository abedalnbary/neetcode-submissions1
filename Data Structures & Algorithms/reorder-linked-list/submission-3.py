# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        slow,fast=head,head.next
        while fast and fast.next:
          slow=slow.next
          fast=fast.next.next
        secound=slow.next
        prev=slow.next=None
        while secound:
            tmp=secound.next
            secound.next=prev
            prev=secound
            secound=tmp
        first,secound=head,prev
        while secound:
            tmp1,tmp2=first.next,secound.next
            first.next=secound
            secound.next=tmp1
            first,secound=tmp1,tmp2
    
        