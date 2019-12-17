SELECT * FROM DocumentType;
SELECT * FROM Document;
SELECT * FROM DocumentStatus;


SELECT * FROM Adress;


SELECT * FROM Employee;

SELECT * FROM Position;


ALTER TABLE  Employee 
    DROP CONSTRAINT fk_PositionId_Position 

ALTER TABLE   Employee 
    add CONSTRAINT fk_PositionId_Position FOREIGN KEY (PositionId)
    REFERENCES Position (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE
    
    

    
ALTER TABLE   Employee 
    add CONSTRAINT fk_AdressId_Position FOREIGN KEY (AddressId)
    REFERENCES [Adress] (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE


-----

ALTER TABLE   Document 
    add CONSTRAINT fk_DocumentTypeId_Position FOREIGN KEY (DocumentTypeId)
    REFERENCES DocumentType (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE   

 ALTER TABLE   DocumentStatus 
    add CONSTRAINT fk_RenderId_Position FOREIGN KEY (RenderId)
    REFERENCES Employee (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE

 ALTER TABLE   DocumentStatus 
    add CONSTRAINT fk_ReceiverId_Position FOREIGN KEY (ReceiverId)
    REFERENCES Employee (Id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION    



 ALTER TABLE   DocumentStatus 
    add CONSTRAINT fk_DocumentId_Position FOREIGN KEY (DocumentId)
    REFERENCES Document (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE       


 
