SELECT 
    c.*, a.*
FROM
    Client c
        INNER JOIN
    Account a ON c.idClient = a.Client_idClient