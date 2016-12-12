year=input("请输入一个年份")
while year.isdigit()==False:
    print("请输入数字年份！")
    year=input("请输入一个年份")
year=int(year)
if year%400==0:
    print(year,"是闰年")
elif year%4==0 and year%100!=0:
    print(year,"是闰年")
else:
    print(year,"不是闰年")
    
