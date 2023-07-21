/*
 Navicat Premium Data Transfer

 Source Server         : Postgres14
 Source Server Type    : PostgreSQL
 Source Server Version : 140006 (140006)
 Source Host           : localhost:5432
 Source Catalog        : AutoSalonDB
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 140006 (140006)
 File Encoding         : 65001

 Date: 19/06/2023 00:04:38
*/


-- ----------------------------
-- Sequence structure for body_types_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."body_types_id_seq";
CREATE SEQUENCE "public"."body_types_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for brand_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."brand_id_seq";
CREATE SEQUENCE "public"."brand_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for car_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."car_id_seq";
CREATE SEQUENCE "public"."car_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for clients_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."clients_id_seq";
CREATE SEQUENCE "public"."clients_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for purchases_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."purchases_id_seq";
CREATE SEQUENCE "public"."purchases_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for technical_details_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."technical_details_id_seq";
CREATE SEQUENCE "public"."technical_details_id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Table structure for body_types
-- ----------------------------
DROP TABLE IF EXISTS "public"."body_types";
CREATE TABLE "public"."body_types" (
  "id" int4 NOT NULL DEFAULT nextval('body_types_id_seq'::regclass),
  "body_type" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of body_types
-- ----------------------------
INSERT INTO "public"."body_types" VALUES (1, 'седан');
INSERT INTO "public"."body_types" VALUES (2, 'хэтчбек');
INSERT INTO "public"."body_types" VALUES (3, 'купе');
INSERT INTO "public"."body_types" VALUES (4, 'кабриолет');
INSERT INTO "public"."body_types" VALUES (5, 'внедорожник');
INSERT INTO "public"."body_types" VALUES (6, 'пикап');
INSERT INTO "public"."body_types" VALUES (7, 'минивэн');
INSERT INTO "public"."body_types" VALUES (8, 'лимузин');

-- ----------------------------
-- Table structure for brands
-- ----------------------------
DROP TABLE IF EXISTS "public"."brands";
CREATE TABLE "public"."brands" (
  "id" int4 NOT NULL DEFAULT nextval('brand_id_seq'::regclass),
  "brand" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of brands
-- ----------------------------
INSERT INTO "public"."brands" VALUES (1, 'Лада');
INSERT INTO "public"."brands" VALUES (2, 'Тойота');
INSERT INTO "public"."brands" VALUES (3, 'Форд');
INSERT INTO "public"."brands" VALUES (4, 'БМВ');
INSERT INTO "public"."brands" VALUES (5, 'Мерседес');
INSERT INTO "public"."brands" VALUES (6, 'Ауди');
INSERT INTO "public"."brands" VALUES (7, 'Вольво');
INSERT INTO "public"."brands" VALUES (8, 'Хонда');

-- ----------------------------
-- Table structure for car
-- ----------------------------
DROP TABLE IF EXISTS "public"."car";
CREATE TABLE "public"."car" (
  "id" int4 NOT NULL DEFAULT nextval('car_id_seq'::regclass),
  "model" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "availability" bool NOT NULL,
  "color" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "price" int4 NOT NULL,
  "brand_id" int4 NOT NULL,
  "technical_details_id" int4 NOT NULL
)
;

-- ----------------------------
-- Records of car
-- ----------------------------
INSERT INTO "public"."car" VALUES (1, 'Гранта', 't', 'белый', 500000, 1, 1);
INSERT INTO "public"."car" VALUES (2, 'Королла', 't', 'серый', 1200000, 2, 2);
INSERT INTO "public"."car" VALUES (3, 'Фокус', 'f', 'красный', 800000, 3, 3);
INSERT INTO "public"."car" VALUES (4, 'X5', 't', 'черный', 4000000, 4, 4);
INSERT INTO "public"."car" VALUES (5, 'S-класс', 'f', 'синий', 6000000, 5, 5);
INSERT INTO "public"."car" VALUES (6, 'A6', 't', 'зеленый', 3000000, 6, 6);
INSERT INTO "public"."car" VALUES (7, 'XC90', 't', 'желтый', 3500000, 7, 7);
INSERT INTO "public"."car" VALUES (8, 'Цивик', 'f', 'фиолетовый', 1500000, 8, 8);

-- ----------------------------
-- Table structure for clients
-- ----------------------------
DROP TABLE IF EXISTS "public"."clients";
CREATE TABLE "public"."clients" (
  "id" int4 NOT NULL DEFAULT nextval('clients_id_seq'::regclass),
  "lastname" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "firstname" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "patronymic" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "passport" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "address" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "phone" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of clients
-- ----------------------------
INSERT INTO "public"."clients" VALUES (1, 'Иванов', 'Иван', 'Иванович', '4509 123456', 'ул. Ленина, д.1 кв.1', '+7(999)111-11-11');
INSERT INTO "public"."clients" VALUES (2, 'Петрова', 'Анна', 'Сергеевна', '4510 234567', 'ул. Советская, д.2 кв.2', '+7(999)222-22-22');
INSERT INTO "public"."clients" VALUES (3, 'Сидоров', 'Петр', 'Петрович', '4511 345678', 'ул. Комсомольская, д.3 кв.3', '+7(999)333-33-33');
INSERT INTO "public"."clients" VALUES (4, 'Смирнова', 'Елена', 'Андреевна', '4512 456789', 'ул. Октябрьская, д.4 кв.4', '+7(999)444-44-44');
INSERT INTO "public"."clients" VALUES (5, 'Новиков', 'Андрей', 'Владимирович', '4513 567890', 'ул. Победы, д.5 кв.5', '+7(999)555-55-55');
INSERT INTO "public"."clients" VALUES (6, 'Кузнецова', 'Ольга', 'Николаевна', '4514 678901', 'ул. Мира, д.6 кв.6', '+7(999)666-66-66');
INSERT INTO "public"."clients" VALUES (7, 'Морозов', 'Дмитрий', 'Александрович', '4515 789012', 'ул. Ленинградская, д.7 кв.7', '+7(999)777-77-77');
INSERT INTO "public"."clients" VALUES (8, 'Зайцева', 'Мария', 'Игоревна', '4516 890123', 'ул. Московская д.8 кв.8', '+7(999)888-88-88');

-- ----------------------------
-- Table structure for purchases
-- ----------------------------
DROP TABLE IF EXISTS "public"."purchases";
CREATE TABLE "public"."purchases" (
  "id" int4 NOT NULL DEFAULT nextval('purchases_id_seq'::regclass),
  "car_id" int4 NOT NULL,
  "client_id" int4 NOT NULL,
  "datee" date,
  "payment_type" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of purchases
-- ----------------------------
INSERT INTO "public"."purchases" VALUES (1, 1, 1, '2023-06-01', 'наличные');
INSERT INTO "public"."purchases" VALUES (2, 2, 2, '2023-06-02', 'безналичный расчет');
INSERT INTO "public"."purchases" VALUES (3, 4, 3, '2023-06-03', 'кредит');
INSERT INTO "public"."purchases" VALUES (4, 6, 4, '2023-06-04', 'лизинг');
INSERT INTO "public"."purchases" VALUES (5, 7, 5, '2023-06-05', 'наличные');
INSERT INTO "public"."purchases" VALUES (6, 8, 6, '2023-06-06', 'безналичный расчет');

-- ----------------------------
-- Table structure for technical_details
-- ----------------------------
DROP TABLE IF EXISTS "public"."technical_details";
CREATE TABLE "public"."technical_details" (
  "id" int4 NOT NULL DEFAULT nextval('technical_details_id_seq'::regclass),
  "doors_count" int4 NOT NULL,
  "seats_count" int4 NOT NULL,
  "engine_capacity" int4 NOT NULL,
  "body_type_id" int4 NOT NULL,
  "engine_type" varchar(255) COLLATE "pg_catalog"."default" NOT NULL,
  "engine_location" varchar(255) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of technical_details
-- ----------------------------
INSERT INTO "public"."technical_details" VALUES (1, 4, 5, 1600, 1, 'бензиновый', 'передний');
INSERT INTO "public"."technical_details" VALUES (2, 4, 5, 1800, 1, 'гибридный', 'передний');
INSERT INTO "public"."technical_details" VALUES (3, 5, 5, 2000, 2, 'дизельный', 'передний');
INSERT INTO "public"."technical_details" VALUES (4, 5, 7, 3000, 5, 'бензиновый', 'передний');
INSERT INTO "public"."technical_details" VALUES (5, 4, 5, 4000, 3, 'бензиновый', 'задний');
INSERT INTO "public"."technical_details" VALUES (6, 4, 5, 2500, 4, 'дизельный', 'передний');
INSERT INTO "public"."technical_details" VALUES (7, 5, 7, 3500, 5, 'гибридный', 'передний');
INSERT INTO "public"."technical_details" VALUES (8, 4, 5, 1500, 2, 'бензиновый', 'передний');

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."body_types_id_seq"
OWNED BY "public"."body_types"."id";
SELECT setval('"public"."body_types_id_seq"', 8, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."brand_id_seq"
OWNED BY "public"."brands"."id";
SELECT setval('"public"."brand_id_seq"', 8, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."car_id_seq"
OWNED BY "public"."car"."id";
SELECT setval('"public"."car_id_seq"', 8, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."clients_id_seq"
OWNED BY "public"."clients"."id";
SELECT setval('"public"."clients_id_seq"', 8, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."purchases_id_seq"
OWNED BY "public"."purchases"."id";
SELECT setval('"public"."purchases_id_seq"', 6, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."technical_details_id_seq"
OWNED BY "public"."technical_details"."id";
SELECT setval('"public"."technical_details_id_seq"', 8, true);

-- ----------------------------
-- Primary Key structure for table body_types
-- ----------------------------
ALTER TABLE "public"."body_types" ADD CONSTRAINT "body_types_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table brands
-- ----------------------------
ALTER TABLE "public"."brands" ADD CONSTRAINT "brand_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table car
-- ----------------------------
ALTER TABLE "public"."car" ADD CONSTRAINT "car_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table clients
-- ----------------------------
ALTER TABLE "public"."clients" ADD CONSTRAINT "clients_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table purchases
-- ----------------------------
ALTER TABLE "public"."purchases" ADD CONSTRAINT "purchases_pkey" PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table technical_details
-- ----------------------------
ALTER TABLE "public"."technical_details" ADD CONSTRAINT "technical_details_pkey" PRIMARY KEY ("id");
