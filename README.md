# KOLA
Kola is an Inventory Management application to assist with cataloguing costumes, props and accessories by the Costume Shop for the Theater department.

### About 
___
>Butler University Theater is an incubator for the next generation of theatre artists. Renown as one of the best programs in the country, Butler Theatre strives to push the boundaries of art.

A critical portion of Butler Theatre is the costume shop. Under the umbrella of the costume shop; props, clothes, shoes, and other items are created, modified, maintained and provided to the department for use in productions. As a result of the support role that the costume shop gives to the theatre department a lot of items are collected and stored for future use. These items are numerous and at times difficult to manage as the years go on. The university granted the department space beneath the soon-to-be-constructed parking garage to store their costumes and props, and the department would like to acquire an efficient cataloging system to coincide with the transfer.

The Butler University Theater Costume Shop (BUTCS) department seeks an organizational app for costume storage. The hope is to attach barcodes to costumes and large accessories and associate that barcode with a page that allows an item history to be tracked via pictures, search phrases/categories in terms of available rentals, current location, and last time of use etc.

Our Engineering Projects in Community Service (EPICS) team is tasked with creating an application that will facilitate cataloguing of the Theatre Department’s stock alongside a few added bells and whistles such as rental and administrative systems. With the guidance of facilitator, Dr. Panos Linos, we aim to provide an adequate solution.

- Primary Contact: Teka England (tengland@butler.edu)
- Secondary Contacts: Panos Linos (plinos@butler.edu)

### TLDR Feature Rundown
______________________________________________________

#### Database:
- Catalogues items based on physical attributes, storage location, and other identifying features.
- Items are uniquely identified through a barcode ID and sequential database ID.
- Related attributes are divided into tables in order to cut the fat and increase the ease of navigation.
- Database has a built in auto-backup feature that will periodically create a snapshot of the database that can be reverted to in case of an emergency.
- Modification and searching of the database is done through the PHP web application.


#### Web Application:
- Filter/Search costume pieces by one or more of the following characteristics:
    - Characteristics (color, measurements, material, ect...)
    - Era (20’s, 30’s, medieval, fantasy ect...)
    - Clothing Type (hat, dress, shoe, ect…)
    - Location in Storage (tentatively denoted by section and row)
    - Previous Productions (Nutcracker: 1980, A Midsummer’s Night’s Dream: 2000, ect…)
    - Check-in Status (to filter what may currently be in stock)
- Search results may be displayed as a text list or in an image grid displaying the primary image of each item. Results may be printed or sent to PDF
- Item information screen contains all relevant information about the item in question as well as pictures to identify the item. Linked items and rental history will populate as they are filled.
- As an admin, one has additional actions available to take:
    - Add, remove, and edit items in the database through the front end. This includes the manufacturing of “outfits” or individual items that link together.  
    - Manage rentals to both Butler students and other organizations using the barcode system.
    - After reading in the item barcode and inputting the renter information, one can print out a rental sheet for records.
    - Revert to a previous database snapshot should it be necessary.
