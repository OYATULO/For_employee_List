-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Май 14 2023 г., 00:26
-- Версия сервера: 10.4.28-MariaDB
-- Версия PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `cdstructure2`
--

-- --------------------------------------------------------

--
-- Структура таблицы `accounting`
--

CREATE TABLE `accounting` (
  `Id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `CompanyDStructureId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `accounting`
--

INSERT INTO `accounting` (`Id`, `Name`, `CompanyDStructureId`) VALUES
(1, 'Бухгалтерия ', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `companydstructure`
--

CREATE TABLE `companydstructure` (
  `Id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `companydstructure`
--

INSERT INTO `companydstructure` (`Id`, `Name`) VALUES
(1, 'структура отделов компании');

-- --------------------------------------------------------

--
-- Структура таблицы `cservicedepartment`
--

CREATE TABLE `cservicedepartment` (
  `Id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `CompanyDStructureId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `cservicedepartment`
--

INSERT INTO `cservicedepartment` (`Id`, `Name`, `CompanyDStructureId`) VALUES
(1, 'Отдел по обслуживанию клиентов ', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `employes`
--

CREATE TABLE `employes` (
  `Id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `AccountingId` int(11) DEFAULT NULL,
  `SubMenuid` int(11) DEFAULT NULL,
  `Submenu2id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `employes`
--

INSERT INTO `employes` (`Id`, `Name`, `AccountingId`, `SubMenuid`, `Submenu2id`) VALUES
(17, 'Иван', 1, 16, 3),
(18, 'Андрей', NULL, 18, NULL),
(19, 'Иван 1', NULL, NULL, 1),
(20, 'Иван 2', NULL, 18, NULL),
(21, 'Андрей 2', NULL, 19, NULL),
(22, 'Миша', NULL, 20, NULL),
(23, 'Иван Иванов', NULL, NULL, 1),
(24, 'Андрей 4', NULL, NULL, 4),
(25, 'Иван 5', NULL, 17, NULL),
(26, 'Иван 7', NULL, NULL, 1),
(27, 'Иван 8', NULL, NULL, 2),
(28, 'Иван 12', 1, NULL, NULL),
(29, 'Андрей 45', NULL, 19, NULL),
(30, 'Иван 814', NULL, 18, NULL),
(31, 'Иван 1244', NULL, 18, NULL),
(32, 'Андрей 444', NULL, NULL, 4),
(33, 'Иван 524', NULL, NULL, 4),
(34, 'Иван 724', NULL, NULL, 4),
(35, 'Иван 8', NULL, NULL, 3),
(36, 'Иван 1222', NULL, NULL, NULL),
(37, 'Андрей 4522', NULL, NULL, 2),
(38, 'Иван 814', NULL, NULL, NULL),
(39, 'Иван 1244', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `pdepartment`
--

CREATE TABLE `pdepartment` (
  `Id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `CompanyDStructureId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `pdepartment`
--

INSERT INTO `pdepartment` (`Id`, `Name`, `CompanyDStructureId`) VALUES
(1, 'Производственный отдел', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `submenu`
--

CREATE TABLE `submenu` (
  `id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `CServiceDepartmentId` int(11) DEFAULT NULL,
  `PDepartmentId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `submenu`
--

INSERT INTO `submenu` (`id`, `Name`, `CServiceDepartmentId`, `PDepartmentId`) VALUES
(16, 'Отдел продаж', 1, NULL),
(17, 'Отдел логистики', 1, NULL),
(18, 'Инженерный отдел', NULL, 1),
(19, 'Отдел проверки качества', NULL, 1),
(20, 'Отдел закупок', NULL, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `submenu2`
--

CREATE TABLE `submenu2` (
  `id` int(11) NOT NULL,
  `Name` varchar(128) DEFAULT NULL,
  `SubMenuid` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `submenu2`
--

INSERT INTO `submenu2` (`id`, `Name`, `SubMenuid`) VALUES
(1, 'Отдел оптовых продаж', 16),
(2, 'Отдел розничных продаж ', 16),
(3, 'Склад ', 17),
(4, 'Отдел доставки', 17);

-- --------------------------------------------------------

--
-- Структура таблицы `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230511211215_mymigration', '7.0.5'),
('20230511212558_mymigration_update', '7.0.5'),
('20230511212848_mymigration_lastupdate', '7.0.5');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `accounting`
--
ALTER TABLE `accounting`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Accounting_CompanyDStructureId` (`CompanyDStructureId`);

--
-- Индексы таблицы `companydstructure`
--
ALTER TABLE `companydstructure`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `cservicedepartment`
--
ALTER TABLE `cservicedepartment`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_CServiceDepartment_CompanyDStructureId` (`CompanyDStructureId`);

--
-- Индексы таблицы `employes`
--
ALTER TABLE `employes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Employes_AccountingId` (`AccountingId`),
  ADD KEY `IX_Employes_Submenu2id` (`Submenu2id`),
  ADD KEY `IX_Employes_SubMenuid` (`SubMenuid`);

--
-- Индексы таблицы `pdepartment`
--
ALTER TABLE `pdepartment`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_PDepartment_CompanyDStructureId` (`CompanyDStructureId`);

--
-- Индексы таблицы `submenu`
--
ALTER TABLE `submenu`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_SubMenu_CServiceDepartmentId` (`CServiceDepartmentId`),
  ADD KEY `IX_SubMenu_PDepartmentId` (`PDepartmentId`);

--
-- Индексы таблицы `submenu2`
--
ALTER TABLE `submenu2`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_Submenu2_SubMenuid` (`SubMenuid`);

--
-- Индексы таблицы `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `accounting`
--
ALTER TABLE `accounting`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `companydstructure`
--
ALTER TABLE `companydstructure`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `cservicedepartment`
--
ALTER TABLE `cservicedepartment`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `employes`
--
ALTER TABLE `employes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT для таблицы `pdepartment`
--
ALTER TABLE `pdepartment`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `submenu`
--
ALTER TABLE `submenu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `submenu2`
--
ALTER TABLE `submenu2`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `accounting`
--
ALTER TABLE `accounting`
  ADD CONSTRAINT `FK_Accounting_CompanyDStructure_CompanyDStructureId` FOREIGN KEY (`CompanyDStructureId`) REFERENCES `companydstructure` (`Id`);

--
-- Ограничения внешнего ключа таблицы `cservicedepartment`
--
ALTER TABLE `cservicedepartment`
  ADD CONSTRAINT `FK_CServiceDepartment_CompanyDStructure_CompanyDStructureId` FOREIGN KEY (`CompanyDStructureId`) REFERENCES `companydstructure` (`Id`);

--
-- Ограничения внешнего ключа таблицы `employes`
--
ALTER TABLE `employes`
  ADD CONSTRAINT `FK_Employes_Accounting_AccountingId` FOREIGN KEY (`AccountingId`) REFERENCES `accounting` (`Id`),
  ADD CONSTRAINT `FK_Employes_SubMenu_SubMenuid` FOREIGN KEY (`SubMenuid`) REFERENCES `submenu` (`id`),
  ADD CONSTRAINT `FK_Employes_Submenu2_Submenu2id` FOREIGN KEY (`Submenu2id`) REFERENCES `submenu2` (`id`);

--
-- Ограничения внешнего ключа таблицы `pdepartment`
--
ALTER TABLE `pdepartment`
  ADD CONSTRAINT `FK_PDepartment_CompanyDStructure_CompanyDStructureId` FOREIGN KEY (`CompanyDStructureId`) REFERENCES `companydstructure` (`Id`);

--
-- Ограничения внешнего ключа таблицы `submenu`
--
ALTER TABLE `submenu`
  ADD CONSTRAINT `FK_SubMenu_CServiceDepartment_CServiceDepartmentId` FOREIGN KEY (`CServiceDepartmentId`) REFERENCES `cservicedepartment` (`Id`),
  ADD CONSTRAINT `FK_SubMenu_PDepartment_PDepartmentId` FOREIGN KEY (`PDepartmentId`) REFERENCES `pdepartment` (`Id`);

--
-- Ограничения внешнего ключа таблицы `submenu2`
--
ALTER TABLE `submenu2`
  ADD CONSTRAINT `FK_Submenu2_SubMenu_SubMenuid` FOREIGN KEY (`SubMenuid`) REFERENCES `submenu` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
