import random #调用random模块
n = random.randint (0,100) #生成0-100的随机数字
i=10 #猜数字的次数
print("----------猜数字游戏----------")
print("*你共有",i,"次机会*")
guess = int(input('输入一个数字:')) #输入的数字复制给guess
maxn=100 #最大随机数字
minn=0  #最小随机数字
while i>1 : #循环条件
    if guess == n:
        print("猜对了")
        break  #输入数字为产生的随机数时退出循环
    elif guess > n:
        maxn=guess
        print("猜错了,你猜的数大于正确数字。")
    elif guess < n:
        minn=guess
        print("猜错了,你猜的数小于正确数字。")
    print("正确数字数字在",minn,"和",maxn,"之间。") #显示猜数字的区间
    print("还有",i-1,"次机会。")
    guess= int(input("!!!请重新输入一个数字:"))
    i=i-1
if guess!=n: #当while循环结束并符合判定条件时
    print("其实，这个数是",n)
print('游戏结束')
