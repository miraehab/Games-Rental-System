/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/26/2022 8:05:35 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GAME') and o.name = 'FK_GAME_MANAGE_ADMIN')
alter table GAME
   drop constraint FK_GAME_MANAGE_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT_CLIENT')
alter table RENT
   drop constraint FK_RENT_RENT_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RENT') and o.name = 'FK_RENT_RENT2_GAME')
alter table RENT
   drop constraint FK_RENT_RENT2_GAME
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GAME')
            and   name  = 'MANAGE_FK'
            and   indid > 0
            and   indid < 255)
   drop index GAME.MANAGE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GAME')
            and   type = 'U')
   drop table GAME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RENT')
            and   name  = 'RENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index RENT.RENT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RENT')
            and   type = 'U')
   drop table RENT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   A_USERNAME           varchar(150)         not null,
   A_PASSWORD           varchar(150)         not null,
   constraint PK_ADMIN primary key (A_USERNAME)
)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   C_PHONENUM           int                  not null,
   C_FIRSTNAME          varchar(150)         not null,
   C_LASTNAME           varchar(150)         not null,
   constraint PK_CLIENT primary key (C_PHONENUM)
)
go

/*==============================================================*/
/* Table: GAME                                                  */
/*==============================================================*/
create table GAME (
   G_ID                 int                  not null,
   A_USERNAME           varchar(150)         null,
   AMOUNT               int                  not null,
   PRICE                float                not null,
   G_NAME               varchar(150)         not null,
   V_NAME               varchar(150)         not null,
   G_DATE               datetime             not null,
   constraint PK_GAME primary key (G_ID)
)
go

/*==============================================================*/
/* Index: MANAGE_FK                                             */
/*==============================================================*/




create nonclustered index MANAGE_FK on GAME (A_USERNAME ASC)
go

/*==============================================================*/
/* Table: RENT                                                  */
/*==============================================================*/
create table RENT (
   C_PHONENUM           int                  not null,
   G_ID                 int                  not null,
   RENT_DATE            datetime             not null,
   RETURN_DATE          datetime             not null,
   constraint PK_RENT primary key (C_PHONENUM, G_ID)
)
go

/*==============================================================*/
/* Index: RENT_FK                                               */
/*==============================================================*/




create nonclustered index RENT_FK on RENT (C_PHONENUM ASC)
go

/*==============================================================*/
/* Index: RENT2_FK                                              */
/*==============================================================*/




create nonclustered index RENT2_FK on RENT (G_ID ASC)
go

alter table GAME
   add constraint FK_GAME_MANAGE_ADMIN foreign key (A_USERNAME)
      references ADMIN (A_USERNAME)
go

alter table RENT
   add constraint FK_RENT_RENT_CLIENT foreign key (C_PHONENUM)
      references CLIENT (C_PHONENUM)
go

alter table RENT
   add constraint FK_RENT_RENT2_GAME foreign key (G_ID)
      references GAME (G_ID)
go

