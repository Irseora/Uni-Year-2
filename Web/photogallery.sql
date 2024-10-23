-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 06, 2024 at 11:05 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `photogallery`
--
CREATE DATABASE IF NOT EXISTS `photogallery` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `photogallery`;

-- --------------------------------------------------------

--
-- Table structure for table `carousel`
--

CREATE TABLE `carousel` (
  `id` int(11) NOT NULL,
  `file_name` varchar(64) NOT NULL,
  `file_description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `carousel`
--

INSERT INTO `carousel` (`id`, `file_name`, `file_description`) VALUES
(1, 'gift.jpg', 'Gift'),
(2, 'rage.jpg', 'Rage'),
(3, 'space.jpg', 'Space'),
(4, 'powerpuff-girlies.jpg', 'Powerpuff Girlies');

-- --------------------------------------------------------

--
-- Table structure for table `galleries`
--

CREATE TABLE `galleries` (
  `id` int(11) NOT NULL,
  `title` varchar(64) NOT NULL,
  `title_description` varchar(64) NOT NULL,
  `img` varchar(64) NOT NULL,
  `long_description` varchar(255) NOT NULL,
  `id_user` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `galleries`
--

INSERT INTO `galleries` (`id`, `title`, `title_description`, `img`, `long_description`, `id_user`) VALUES
(7, 'FFFrens', 'De ce ii zice fantezia finala daca is asa multe?', '1717530108_space.jpg', 'According to all known laws of aviation, there is no way a bee should be able to fly. Its wings are too small to get its fat little body off the ground. The bee, of course, flies anyway because bees don\'t care what humans think is impossible.', 1),
(9, 'Fermierii Anului', 'Purple Shorts', '1717532625_gift.jpg', 'That concludes our ceremonies And begins your career at Honex Industries! Will we pick our job today? I heard it\'s just orientation. Heads up! Here we go. Keep your hands and antennas inside the tram at all times.', 11),
(10, 'Girl, Same', 'Cliff-faced as usual, I see', '1717533299_rage.jpg', 'You got a rain advisory today, and as you all know, bees cannot fly in rain. So be careful. As always, watch your brooms, hockey sticks, dogs, birds, bears and bats. Also, I got a couple of reports of root beer being poured on us.', 12),
(11, 'Powerpuff Adventures', 'Then I took an arrow in the knee...', '1717533465_powerpuff-girlies.png', 'I pick up some pollen here, sprinkle it over here. Maybe a dash over there, a pinch on that one. See that? It\'s a little bit of magic. That\'s amazing. Why do we do that? That\'s pollen power. More pollen, more flowers, more nectar, more honey for us. Cool.', 1);

-- --------------------------------------------------------

--
-- Table structure for table `pictures`
--

CREATE TABLE `pictures` (
  `id` int(11) NOT NULL,
  `id_gallery` int(11) NOT NULL,
  `picture` varchar(127) NOT NULL,
  `short_title_description` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pictures`
--

INSERT INTO `pictures` (`id`, `id_gallery`, `picture`, `short_title_description`) VALUES
(14, 7, '1717530108_soup.jpg', 'Soup'),
(15, 7, '1717530108_violin-violence.jpg', 'Violin Violence'),
(16, 7, '1717530108_egg.jpg', 'Egg'),
(17, 7, '1717530108_storytime.jpg', 'Storytime'),
(18, 7, '1717530108_space.jpg', 'Space'),
(21, 9, '1717532625_trains.jpg', 'Trains'),
(22, 9, '1717532625_investigation.jpg', 'Investigation'),
(23, 9, '1717532625_pool-party.jpg', 'Pool Party'),
(24, 9, '1717532625_gift.jpg', 'Gift'),
(25, 10, '1717533299_cash.jpg', 'Cash'),
(26, 10, '1717533299_self-control.jpg', 'Self-Control'),
(27, 10, '1717533299_rage.jpg', 'Rage'),
(28, 11, '1717533465_powerpuff-girlies.png', 'Powerpuff Girlies'),
(29, 11, '1717533465_not-evil.jpg', 'Not evil, pinky promise');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `user` varchar(45) NOT NULL,
  `password` varchar(60) NOT NULL,
  `user_image` varchar(64) DEFAULT NULL,
  `user_short_description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `user`, `password`, `user_image`, `user_short_description`) VALUES
(1, 'admin', '$2a$12$AHOYEwJbhUZf8KVlyQ1pbOSDP9KhHpFv5lSZdgjqGjqcwJZiA8G1m', 'admin_image.jpg', 'Forg'),
(11, 'user1', '$2y$10$dD.FTQYtKgNxbRdqN8lM2.ToU.gTagPUT.DC3vnmEVBSZO607ADfW', '1717599653_1717599099_user1_image.jpg', 'Ducky'),
(12, 'user2', '$2a$12$toMnSDU1rP2bSjiI0poK../9ridA1ug4EQZ94a.zZsE0GazctjYAG', 'user2_image.jpg', 'Meow'),
(13, 'user3', '$2y$10$dYZTHMZvNOruL9dwKHLmfuzPT6L.Io8McRiFa25vDZ7Gbwv9b7056', '1717699385_goobbue.png', 'Gob gob'),
(14, 'user4', '$2y$10$KKmqgROnJKn0DHU1deV2G.E9R7w1eHdlccg8KXA6dLzksUHswmqki', '1717699643_image_2024-06-06_214721798.png', 'Axi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `carousel`
--
ALTER TABLE `carousel`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idx_file_name` (`file_name`);

--
-- Indexes for table `galleries`
--
ALTER TABLE `galleries`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_ID_USER_idx` (`id_user`);

--
-- Indexes for table `pictures`
--
ALTER TABLE `pictures`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_ID_GALLERY` (`id_gallery`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `user_UNIQUE` (`user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `carousel`
--
ALTER TABLE `carousel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `galleries`
--
ALTER TABLE `galleries`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `pictures`
--
ALTER TABLE `pictures`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `galleries`
--
ALTER TABLE `galleries`
  ADD CONSTRAINT `FK_ID_USER` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pictures`
--
ALTER TABLE `pictures`
  ADD CONSTRAINT `FK_ID_GALLERY` FOREIGN KEY (`id_gallery`) REFERENCES `galleries` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
