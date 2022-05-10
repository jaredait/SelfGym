if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RUTINA_EJERCICIO') and o.name = 'FK_RUTINA_E_RELATIONS_RUTINA')
alter table RUTINA_EJERCICIO
   drop constraint FK_RUTINA_E_RELATIONS_RUTINA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RUTINA_EJERCICIO') and o.name = 'FK_RUTINA_E_RELATIONS_EJERCICI')
alter table RUTINA_EJERCICIO
   drop constraint FK_RUTINA_E_RELATIONS_EJERCICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO_RUTINA') and o.name = 'FK_USUARIO__RELATIONS_USUARIO')
alter table USUARIO_RUTINA
   drop constraint FK_USUARIO__RELATIONS_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO_RUTINA') and o.name = 'FK_USUARIO__RELATIONS_RUTINA')
alter table USUARIO_RUTINA
   drop constraint FK_USUARIO__RELATIONS_RUTINA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EJERCICIO')
            and   type = 'U')
   drop table EJERCICIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LUGARES_RECREATIVOS')
            and   type = 'U')
   drop table LUGARES_RECREATIVOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RUTINA')
            and   type = 'U')
   drop table RUTINA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RUTINA_EJERCICIO')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index RUTINA_EJERCICIO.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RUTINA_EJERCICIO')
            and   name  = 'RELATIONSHIP_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index RUTINA_EJERCICIO.RELATIONSHIP_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RUTINA_EJERCICIO')
            and   type = 'U')
   drop table RUTINA_EJERCICIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO_RUTINA')
            and   name  = 'RELATIONSHIP_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO_RUTINA.RELATIONSHIP_2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('USUARIO_RUTINA')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index USUARIO_RUTINA.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO_RUTINA')
            and   type = 'U')
   drop table USUARIO_RUTINA
go

/*==============================================================*/
/* Table: EJERCICIO                                             */
/*==============================================================*/
create table EJERCICIO (
   EJE_ID               int                  IDENTITY(1,1)		not null,
   EJE_CODIGO           varchar(1024)        null,
   EJE_NOMBRE           varchar(100)         null,
   EJE_LINKTUTORIAL     varchar(1024)        null,
   constraint PK_EJERCICIO primary key (EJE_ID)
)
go

/*==============================================================*/
/* Table: LUGARES_RECREATIVOS                                   */
/*==============================================================*/
create table LUGARES_RECREATIVOS (
   LUG_ID               int                  IDENTITY(1,1)		not null,
   LUG_DIRECCION        varchar(1024)        null,
   LUG_NOMBRE           varchar(500)         null,
   constraint PK_LUGARES_RECREATIVOS primary key (LUG_ID)
)
go

/*==============================================================*/
/* Table: RUTINA                                                */
/*==============================================================*/
create table RUTINA (
   RUT_ID               int                  IDENTITY(1,1)		not null,
   RUT_NOMBRE           varchar(100)         null,
   constraint PK_RUTINA primary key (RUT_ID)
)
go

/*==============================================================*/
/* Table: RUTINA_EJERCICIO                                      */
/*==============================================================*/
create table RUTINA_EJERCICIO (
   RUT_EJE_ID           int                  IDENTITY(1,1)		not null,
   RUT_ID               int                  null,
   EJE_ID               int                  null,
   constraint PK_RUTINA_EJERCICIO primary key (RUT_EJE_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_3_FK on RUTINA_EJERCICIO (RUT_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_4_FK on RUTINA_EJERCICIO (EJE_ID ASC)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   USU_NOMBREUSUARIO    varchar(50)          not null,
   USU_CONTRASENA       varchar(50)          null,
   USU_NOMBRE           varchar(50)          null,
   USU_APELLIDO         varchar(50)          null,
   USU_EDAD             int                  null,
   constraint PK_USUARIO primary key (USU_NOMBREUSUARIO)
)
go

/*==============================================================*/
/* Table: USUARIO_RUTINA                                        */
/*==============================================================*/
create table USUARIO_RUTINA (
   USU_RUT_ID           int                  IDENTITY(1,1)		not null,
   USU_NOMBREUSUARIO    varchar(50)          null,
   RUT_ID               int                  null,
   constraint PK_USUARIO_RUTINA primary key (USU_RUT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_1_FK on USUARIO_RUTINA (USU_NOMBREUSUARIO ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/




create nonclustered index RELATIONSHIP_2_FK on USUARIO_RUTINA (RUT_ID ASC)
go

alter table RUTINA_EJERCICIO
   add constraint FK_RUTINA_E_RELATIONS_RUTINA foreign key (RUT_ID)
      references RUTINA (RUT_ID)
go

alter table RUTINA_EJERCICIO
   add constraint FK_RUTINA_E_RELATIONS_EJERCICI foreign key (EJE_ID)
      references EJERCICIO (EJE_ID)
go

alter table USUARIO_RUTINA
   add constraint FK_USUARIO__RELATIONS_USUARIO foreign key (USU_NOMBREUSUARIO)
      references USUARIO (USU_NOMBREUSUARIO)
go

alter table USUARIO_RUTINA
   add constraint FK_USUARIO__RELATIONS_RUTINA foreign key (RUT_ID)
      references RUTINA (RUT_ID)
go
