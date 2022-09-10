create table isci (
	isciMKOD  int identity(1,1) primary key,
	isciAd nvarchar(25),
	isciSoyad nvarchar(25),
	iscivezifeid int ,
	iscimaas float 
)
create table vezife(
	vId int identity(1,1) primary key,
	Vezife nvarchar(30)
)
create table filial(
	filialid int identity(1,1) primary key,
	filial nvarchar(25)
)
create table mehsul(
	mehsulid int identity(1,1) primary key,
	mehsulad nvarchar(25),
	mehsulalisqiymeti  real,
	mehsulsatisqiymeti real
)
create table satis(
	satisid int identity(1,1) primary key,
	satismehsulid int,
	satisisciid int,
	satisTEO real,
	satistarixi date
)
select *from mehsul
insert into satis values (
	1,1,20.55,2020-02-06
)
insert into satis(satismehsulid,satisisciid,satisTEO,satistarixi) values(
	5,5,85.37,'07-01-2019'
)
truncate table vezife
delete isci
where isciMKOD=1
drop table satis

select concat(isciAd , Vezife) as Iscivezife from satis
select isciAd,mehsulad,mehsulsatisqiymeti,mehsulalisqiymeti,satisTEO from satis 
left join isci
on satisisciid=iscimkod
left join mehsul
on mehsulid=satismehsulid 
left join vezife
on iscivezifeid=vid

select count(isciMKOD) as IsciSayi from isci 

select iscimaas as maasazdancoxa from isci order by iscimaas asc


select iscimaas as maascoxdanaza from isci order by iscimaas desc

select *from satis order by satistarixi asc

select concat(isciAd , Vezife) from isci 

select sum(mehsulsatisqiymeti) as satislarincemi from mehsul


select sum(mehsulsatisqiymeti - mehsulalisqiymeti) from mehsul
left join mehsul
on satismehsulid=mehsulid where month(satistarixi)=month(getdate())



select sum( mehsulsatisqiymeti - mehsulalisqiymeti )as sirketgeliri from mehsul


--5
select mehsulid, count(*) as mehsullarinsayi from satis
left join isci
on satisisciid=iscimkod 
left join vezife
on iscivezifeid=vid
left join mehsul
on mehsulid=satismehsulid 
where month(satistarixi)=month(getdate())
group by mehsulid


--6
select isciAd, mehsulalisqiymeti as mehsulunsayi from mehsul
left join mehsul
on mehsulid=satismehsulid

where month(satistarixi)=month(getdate())
group by isciAd,mehsulalisqiymeti


--7
select sum(mehsulsatisqiymeti - mehsulalisqiymeti-satisTEO) as satisdanqalanxeyir from satis
left join mehsul
on satismehsulid=mehsulid where month(satistarixi)=month(getdate())


--9
select mehsulad, count(*) as satilanmehsullarinsayi from satis
left join mehsul
on mehsulid=satismehsulid 
where month(satistarixi)=month(getdate())
group by mehsulad



--10
select mehsulad, max(mehsulid) as encoxsatilanmehsulunsayi from satis
left join mehsul
on mehsulid=satismehsulid 
where month(satistarixi)=month(getdate())
group by mehsulad



create  table iscicedveli(
	MID int identity(1,1) primary key,
	iscicedvelAd nvarchar(25),
	iscicedvelSoyad nvarchar(25),
	iscicedvelAtaad nvarchar(25),
	iscicedvelTevellud date ,
	iscicedvelVezife nvarchar(30),
	iscicedvelIsebaslamavaxti date,
	iscicedvelIsdencixmavaxti date,
	iscicedvelResmimaas real,
	iscicedvelMotivasiyamaas real
)
select iscicedvelAd,iscicedvelSoyad,iscicedvelAtaad,iscicedvelVezife,datediff(year,iscicedvelIsebaslamavaxti,iscicedvelIsdencixmavaxti) as SAAstaj from iscicedveli


select iscicedvelResmimaas, count(iscicedvelResmimaas) *5/ 100 as besyuzdenaz from iscicedveli
group by iscicedvelResmimaas
having count(iscicedvelResmimaas) <=500


select iscicedvelResmimaas, count(iscicedvelResmimaas) *7/ 100 as 'maas500-800' from iscicedveli
group by iscicedvelResmimaas
having count(iscicedvelResmimaas) between 500 and 800



select iscicedvelResmimaas, count(iscicedvelResmimaas) *10/ 100 as 'maas800-1500' from iscicedveli
group by iscicedvelResmimaas
having count(iscicedvelResmimaas) between 800 and 1500


select iscicedvelResmimaas, count(iscicedvelResmimaas) *12/ 100 as maas1500cox from iscicedveli
group by iscicedvelResmimaas
having count(iscicedvelResmimaas) >=1500


select (select iscicedvelResmimaas,iscicedvelMotivasiyamaas from iscicedveli) from(
    select iscicedvelResmimaas, count(iscicedvelResmimaas) *5/ 100 as besyuzdenaz from iscicedveli
    group by iscicedvelResmimaas
    having count(iscicedvelResmimaas) <=500
    union all
    select iscicedvelResmimaas, count(iscicedvelResmimaas) *7/ 100 as 'maas500-800' from iscicedveli
    group by iscicedvelResmimaas
    having count(iscicedvelResmimaas) between 500 and 800
    union all
	select iscicedvelResmimaas, count(iscicedvelResmimaas) *10/ 100 as 'maas800-1500' from iscicedveli
	group by iscicedvelResmimaas
	having count(iscicedvelResmimaas) between 800 and 1500
	union all
	select iscicedvelResmimaas, count(iscicedvelResmimaas) *12/ 100 as maas1500cox from iscicedveli
	group by iscicedvelResmimaas
	having count(iscicedvelResmimaas) >=1500
) as a  
select * from iscicedveli

select *,case 
			when iscicedvelResmimaas<=500 then(iscicedvelResmimaas-((iscicedvelResmimaas*5)/100))
			when iscicedvelResmimaas between 501 and 800 then(iscicedvelResmimaas-((iscicedvelResmimaas*7)/100))
			when iscicedvelResmimaas between 801 and 1500 then(iscicedvelResmimaas-((iscicedvelResmimaas*10)/100))
			else (iscicedvelResmimaas-((iscicedvelResmimaas*12)/100))
			end ResmiMaasVergiSonrasi

from iscicedveli


select *,case 
			when iscicedvelResmimaas<=500 then(iscicedvelMotivasiyamaas+iscicedvelResmimaas-((iscicedvelResmimaas*5)/100))
			when iscicedvelResmimaas between 501 and 800 then(iscicedvelMotivasiyamaas+iscicedvelResmimaas-((iscicedvelResmimaas*7)/100))
			when iscicedvelResmimaas between 801 and 1500 then(iscicedvelMotivasiyamaas+iscicedvelResmimaas-((iscicedvelResmimaas*10)/100))
			else (iscicedvelMotivasiyamaas+iscicedvelResmimaas-((iscicedvelResmimaas*12)/100))
			end YekunResmiMaas
from iscicedveli

select *,case 
	when iscicedvelVezife='Kassir' and year(getdate())-3>=year(iscicedvelIsebaslamavaxti) then (iscicedvelMotivasiyamaas+120)
	else (0)
	end maasartimi3il
from iscicedveli


select *,case 
	when datediff(month,iscicedvelIsebaslamavaxti,getdate())>=6 then ((iscicedvelResmimaas*110)/100)
	else (0)
	end maasartimi6ay
from iscicedveli


create table iscicedveli4(
	ishciMKOD int identity(1,1) primary key,
	ishcicedvelAd nvarchar(25),
	ishcicedvelSoyad nvarchar(25),
	ishcicedvelAtaad nvarchar(25),
	ishcicedvelStaj date ,
	ishcicedvelVezife nvarchar(30),
	ishcicedvelFilial nvarchar(30),
	ishcicedvelEMBT date,
	ishciMaastarixi int ,
	ishcicedvelResmimaas real,
)
select *from iscicedveli4
--4.1
select *,case 
	when datediff(day,ishciMaastarixi,getdate())<=3 then (ishcicedvelAd)
	else (0)
	end maasartimi3gun
from iscicedveli4

--4.2
select *,case 
	when ishcicedvelEMBT=getdate() then (ishcicedvelAd)
	else (0)
	end ishcicedvelEMBTson
from iscicedveli4

--4.3
select *,case 
	when datediff(month,ishcicedvelEMBT,getdate())<=1 then (ishcicedvelAd)
	else (0)
	end ishcicedvelEMBT1ay
from iscicedveli4

--4.4
select *,case 
	when datediff(year,ishcicedvelStaj,getdate())>=2 then ((ishcicedvelResmimaas*110)/100)
	else (0)
	end ishcicedvelResmimaas10faiz
from iscicedveli4