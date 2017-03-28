import json
import time
def readjson():
    Allsalary=0
    count=1
    f=open('Salary.json','r')
    readjsonfile=f.read()
    data=json.loads(readjsonfile)
    data_list=sorted(data.items(), key=lambda item:item[0])
    f.close()
    for i in data.keys():
        money=data[i]
        money[-2:]
        Allsalary=Allsalary+int(money[-2:])
    for j in data_list:
        print(count,"Times",j)
        count+=1
    print("AllMoney=",Allsalary)
def writejson():
    writejson=json.dumps(data,sort_keys=True,indent=4)
    f=open('Salary.json','w')
    f.write(writejson)
    f.close()
if __name__ == '__main__':
    print("     Notice")
    print("Input r To View")
    print("Input w To Record")
    print("Input e To Exit")
    CMD=input("Please enter command:")
    while(CMD!="e"):
        
        if  CMD=="r":
            readjson()
        if CMD=="w":
            f=open('Salary.json','r')
            readjsonfile=f.read()
            data=json.loads(readjsonfile)
            f.close()
            money="Money:"+input("Please enter today's salary:")
            Date="Date:"+time.strftime("%m-%d",time.localtime())
            count=str(len(data)+1)
            print(count,"times.","Today is:",Date[-5:]," Today's salary:",money[-2:])
            today_json={Date:money}
            data=dict(data,**today_json)
            writejson()
        CMD=input("Please enter command:")


