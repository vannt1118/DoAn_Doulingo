create database QLyTRUYEN
use QLyTRUYEN

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[truyen](
	[Matruyen] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Tentruyen] [nvarchar](250) NULL,
	[Noidung] [nvarchar](max) NULL
	)
GO

CREATE TABLE [dbo].[tumoi](
	[matu] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[tentu] [nvarchar](250) NULL,
	[matruyen] [int] NULL,
	[nghia1] [nvarchar](250) NULL,
	[nghia2] [nvarchar](250) NULL,
	[vidu] [nvarchar](max) NULL,
	)
GO

CREATE TABLE [dbo].[tudn](
	[matudn] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[tentu] [nvarchar](250) NULL,
	[nghia] [nvarchar](250) NULL,
	[matu] [nvarchar](250) NULL
	)
GO

CREATE TABLE [dbo].[tutn](
	[matutn] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[tentu] [nvarchar](250) NULL,
	[nghia] [nvarchar](250) NULL,
	[matu] [nvarchar](250) NULL
	)
GO

SET IDENTITY_INSERT [dbo].[truyen] ON 

INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (1, 'Thank you, Mom!','I love my mom. She took care of me when I was very young. She took care of me when I was sick. She taught me how to read. She taught me how to get dressed. She taught me how to button my shirt. She taught me how to tie my shoes. She taught me how to brush my teeth. She taught me to be kind to others. She taught me to tell the truth. She taught me to be polite. She took me to school on my first day of school. She held my hand. She helped me with my homework. She was nice to all my friends. She always cheered me up. Next year I will graduate from high school. I will go to college. I will do well in college. I will do well after college. My mom has taught me well.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (2,'Try to sleep','Norma went to bed. It was eleven. She turned out the light. She lay in bed. It was dark. It was quiet. She could not sleep. She closed her eyes. She tried to sleep, but she could not. She turned the light back on. She opened her book. She started to read her book. It was a good book. She read one page. Then she read another page. After a while, she felt sleepy. She closed the book. She turned out the light. She closed her eyes. She went straight to sleep.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (3,'Red, White and Blue','Tracy looked at the flag. The flag is red, white, and blue. It has 50 white stars. The white stars are on a blue square. The flag has six white stripes. It has seven red stripes. All the stripes are horizontal. They are not vertical. The stripes do not go up and down. They go from left to right. Tracy loves her flag. It is the flag of her country. It is a pretty flag. No other flag has 50 stars. No other flag has 13 stripes.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (4,'Washing Her Hands','Fay went into the bathroom. She turned on the cold water. She turned on the hot water. Warm water came out of the faucet. She put her hands under the warm water. She rubbed her hands together. She picked up a bar of white soap. She rubbed the soap with her hands. She put the soap back. She washed her hands for half a minute. Then she rinsed her hands with the water. She turned off the hot water. She turned off the cold water. She dried her hands with a towel.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (5,'A Thin Man','Richard is a light eater. He does not eat much. He is not a heavy eater. He eats a light breakfast, a light lunch, and a light dinner. Richard is not fat. He is thin. He will always be thin, because he is a light eater. He eats a bowl of cereal for breakfast. He eats a bowl of cereal with milk. He eats a sandwich for lunch. Sometimes it is a fish sandwich. He likes fish. He eats rice and vegetables for dinner. All he eats for dinner is rice and vegetables. He will never get fat.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (6,'Water and An Apple','Jimmy dropped a piece of paper on the floor. He bent over and picked it up. He folded the piece of paper in two. He put it on the table. He picked up a pencil. He wrote a phone number on the piece of paper. He put the pencil on the table. He picked up the scissors. He picked up the piece of paper. He cut the paper in half. He put one-half of the paper on the table. He put the other half with the phone number in his shirt pocket. He put the scissors on the table.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (7,'Buy A New Car','Linda wants to buy a new car. She has an old car. Her old car is a white Honda. Linda wants to buy a new Honda. She wants to buy a new red Honda. She has saved $1,000. She will use $1,000 to help buy the new car. She will give $1,000 to the Honda dealer. The Honda dealer will give her a contract to sign. The contract will require her to pay $400 a month for seven years. Her new red Honda will cost Linda a lot of money. But that is okay, because Linda makes a lot of money.')
INSERT [dbo].[truyen] ([Matruyen],[Tentruyen],[Noidung]) VALUES (8,'Water and An Apple','Susan likes to eat apples. She likes to eat big red apples. She likes to wear a blue hat. She wears a big blue hat on her head. She wears a hat and eats an apple. She drinks some water from a white cup. Susan drinks water and eats apples. She does not cut the apple with a knife. A knife is sharp. She just eats the apple. She holds the apple in her hand. She bites into the apple with her teeth. She licks her lips. She drinks more water. She wipes her mouth with her hand.')

SET IDENTITY_INSERT [dbo].[truyen] OFF
GO

SET IDENTITY_INSERT [dbo].[tumoi] ON 

INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (1,1,'take care of',N'Chăm lo','To take care of someone or something','I just want to make enough money to take care of my family.')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (2,1,'get dressed',N'Mặc quần áo','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (3,1,'tie shoes',N'Buộc dây giày','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (4,1,'brush teeth',N'Đánh răng','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (5,1,'cheered me up',N'Cổ vũ tôi','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (6,1,'tell the truth',N'Nói sự thật','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (7,2,'quiet',N'Im lặng','Making very little noise','She spoke in a quiet voice so as not to wake him.')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (8,2,'turn out',N'Tắt','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (9,2,'lay in bed',N'Nằm trên giường','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (10,2,'close eyes',N'Nhắm mắt','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (10,2,'after a while',N'Sau một lúc','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (11,2,'go straight',N'Đi thẳng','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (12,2,'look at',N'Nhìn vào','To think about a subject carefully so that you can make a decision about it','Management is looking at ways of cutting costs.')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (13,3,'stripe',N'Vạch sọc','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (14,3,'horizontal',N'Nằm ngang','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (15,3,'vertical',N'Thẳng đứng','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (16,4,'bathroom',N'Phòng tắm','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (17,4,'rub',N'Chà xát','To press or be pressed against something with a circular or up-and-down repeated movement.','She yawned and rubbed her eyes sleepily.')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (18,4,'soap',N'Xà phòng','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (19,4,'towel',N'Khăn tắm','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (20,5,'light eater',N'Người ăn ít','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (21,5,'heavy eater',N'Người ăn nhiều','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (22,5,'cereal',N'Ngũ cốc','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (23,6,'bent over',N'Cúi xuống','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (24,6,'pick up',N'Nhặt lên','To learn a new skill or language by practising it rather than being taught it.','Do not bother with the computer manual - you will pick it up as you go along.')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (25,6,'scissors',N'Kéo cắt','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (26,7,'dealer',N'Người bán','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (27,7,'contract',N'Hợp đồng','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (28,7,'sign',N'Ký tên','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (29,8,'require',N'Yêu cầu','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (30,8,'sharp',N'Sắc nhọn','','She nudged me with a sharp elbow, to tell me to be quiet.')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (31,8,'bites into',N'Cắn vào','','')
INSERT [dbo].[tumoi] ([matu],[matruyen],[tentu],[nghia1],[nghia2],[vidu]) 
VALUES (32,8,'licks lips',N'Liếm môi','','')

SET IDENTITY_INSERT [dbo].[tumoi] OFF
GO

SET IDENTITY_INSERT [dbo].[tudn] ON 

INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (1,1,'care for',N'Chăm sóc cho')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (2,1,'look after',N'Chăm sóc cho')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (3,1,'keep an eye on',N'Để mắt tới')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (4,7,'silent',N'Im lặng')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (5,7,'soft',N'Dịu dàng')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (6,7,'peaceful',N'Bình yên')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (8,12,'attitude',N'Thái độ')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (9,12,'outlook',N'Quan điểm')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (10,17,'ache',N'Nhứt mỏi')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (11,17,'throb',N'Đau')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (12,17,'hurt',N'Đau')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (13,24,'get',N'Lấy được')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (14,24,'purchase',N'Mua hàng')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (15,30,'painful',N'Đau')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (16,30,'sore ',N'Đau')
-- Thêm từ đồng nghĩa --
/*
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (17,2,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (18,3,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (19,4,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (20,5,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (21,6,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (22,8,'strike ',N'Cuộc đình công')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (23,9,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (24,10,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (25,11,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (26,13,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (27,14,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (28,15,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (29,16,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (30,18,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (31,19,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (32,20,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (33,21,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (34,22,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (35,23,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (36,27,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (37,25,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (38,26,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (39,28,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (40,29,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (41,30,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (42,31,'',N'')
INSERT [dbo].[tudn] ([matudn],[matu],[tentu],[nghia])
VALUES (43,32,'',N'')*/
-- --
SET IDENTITY_INSERT [dbo].[tudn] OFF
GO

SET IDENTITY_INSERT [dbo].[tutn] ON 

INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (1,1,'neglect',N'Bỏ mặc')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (2,7,'noise',N'Ồn ào')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (3,7,'agitation',N'Sự lay động')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (4,12,'overlook',N'Không chú ý tới')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (5,12,'ignore',N'Phớt lờ')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (6,17,'protect',N'Bảo vệ')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (7,17,'strengthen',N'Củng cố')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (8,17,'keep',N'Giữ')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (9,24,'put down',N'Đặt xuống')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (10,30,'blunt',N'Cùn')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (11,30,'clumsy',N'Hậu đậu')

-- Thêm từ trái nghĩa --
/*
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (12,2,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (13,3,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (14,4,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (15,5,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (16,6,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (17,8,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (18,9,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (19,10,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (20,11,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (21,13,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (22,14,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (23,15,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (24,16,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (25,18,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (26,19,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (27,20,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (28,21,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (29,22,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (30,23,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (31,25,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (32,26,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (33,27,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (34,28,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (35,29,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (36,31,'',N'')
INSERT [dbo].[tutn] ([matutn],[matu],[tentu],[nghia])
VALUES (37,32,'',N'')*/


-- --

SET IDENTITY_INSERT [dbo].[tudn] OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[LayDsTruyen]
as
select TenTruyen from truyen
GO

create proc [dbo].[LayTruyenTheoMa](@matruyen int)
as
select * from truyen
where Matruyen = @matruyen
GO

create proc [dbo].[LayDsTuTheoTruyen](@matruyen int)
as
select matu,tentu,nghia1,nghia2,matruyen,vidu from tumoi
where matruyen = @matruyen
GO



create proc [dbo].[LayDsTuTheoMa](@matu int)
as
select * from tumoi
where matu = @matu
GO

create proc [dbo].[LayDsTuDongNghia](@matu int)
as
select * from tudn
where matu = @matu
GO

create proc [dbo].[LayDsTuTraiNghia](@matu int)
as
select * from tutn
where matu = @matu
GO



