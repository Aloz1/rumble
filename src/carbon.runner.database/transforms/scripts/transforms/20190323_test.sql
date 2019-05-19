CREATE TABLE Test(
  Id char(36) NULL,
  Name varchar(128) NOT NULL DEFAULT 'DEFAULT',
  Value int NOT NULL DEFAULT 100
);

DELIMITER ;;
CREATE TRIGGER Test_Id
  BEFORE INSERT ON Test
  FOR EACH ROW
BEGIN
  IF new.Id IS NULL THEN
    SET new.Id = uuid();
  END IF;
END
;;

DELIMITER ;