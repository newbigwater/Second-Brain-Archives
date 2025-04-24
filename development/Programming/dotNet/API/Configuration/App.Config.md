#DotNet #System #Configuration

## 01. Prepare
### 01.01. App.config 설정 정보를 이용하기 위해 Assembly추가

![](00.%20attachments/Pasted%20image%2020240510104049.png)
### 01.02. App.config에 Setting Info 추가
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
	<appSettings>
		<add key="IP" value="127.0.0.1"/>
		<add key="PORT" value="2572"/>
		<add key="DBNAME" value="MyDatabase"/>
		<add key="USERID" value="ID"/>
		<add key="USERPASSWORD" value="PW"/>
	</appSettings>
</configuration>
```
---
## 02. Programming
```cs

string connstr = 
"SERVER=" 
	+ ConfigurationManager.AppSettings["IP"] + "," 
	+ ConfigurationManager.AppSettings["PORT"] + ";" 
+ "DATABASE=" 
	+ ConfigurationManager.AppSettings["DBNAME"] + ";"
+ "UID=" 
	+ ConfigurationManager.AppSettings["USERID"] + ";"
+ "PASSWORD=" 
	+ ConfigurationManager.AppSettings["USERPASSWORD"];
```
---
## 03. Result

![](00.%20attachments/Pasted%20image%2020240510104427.png)

---
