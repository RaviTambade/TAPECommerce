## JDBC application :
Create class DBManager.java
Create standard DB Connection, PreparedStatement and ResultSet Objects
Perform executeUpdate() operation to insert data into Table
Perform executeQuery() operation to retrieve data from MySQL Table
<br/>
In our case:
Database Name: ecommerce
Username: root
Password: password
Table Name: student
<br/>
There are following six steps involved in building a JDBC application −

-Import the packages − Requires that you include the packages containing the JDBC classes needed for database programming. Most often, using import java.sql.* will suffice.

-Open a connection − Requires using the DriverManager.getConnection() method to create a Connection object, which represents a physical connection with the database.

-Execute a query − Requires using an object of type Statement for building and submitting an SQL statement to the database.

-Extract data from result set − Requires that you use the appropriate ResultSet.getXXX() method to retrieve the data from the result set.


<h1 align="center">What is UML?</h1>

UML stands for Unified Modeling Language and is used to model the Object-Oriented Analysis of a software system. UML is a way of visualizing and documenting a software system by using a collection of diagrams, which helps engineers, businesspeople, and system architects understand the behavior and structure of the system being designed.

Benefits of using UML:

1. Helps develop a quick understanding of a software system.
2. UML modeling helps in breaking a complex system into discrete pieces that can be easily understood.
3. UML’s graphical notations can be used to communicate design decisions.
4. Since UML is independent of any specific platform or language or technology, it is easier to abstract out concepts.
5. It becomes easier to hand the system over to a new team.

<p align="center">
    <img src="/media-files/uml.jpeg" alt="UML">
</p>

**Types of UML Diagrams:** The current UML standards call for 14 different kinds of diagrams. These diagrams are organized into two distinct groups: structural diagrams and behavioral or interaction diagrams. As the names suggest, some UML diagrams analyze and depict the structure of a system or process, whereas others describe the behavior of the system, its actors, and its building components.
The different types are broken down as follows:

**Structural UML diagrams**

* Class diagram
* Object diagram
* Package diagram
* Component diagram
* Composite structure diagram
* Deployment diagram
* Profile diagram

**Behavioral UML diagrams**

* Use case diagram
* Activity diagram
* Sequence diagram
* State diagram
* Communication diagram
* Interaction overview diagram
* Timing diagram

Rest of the sections, we will be focusing on the following UML diagrams:

**Use Case Diagram:** Used to describe a set of user scenarios, this diagram, illustrates the functionality provided by the system.

**Class Diagram:** Used to describe structure and behavior in the use cases, this diagram provides a conceptual model of the system in terms of entities and their relationships.

**Activity Diagram:** Used to model the functional flow-of-control between two or more class objects.

**Sequence Diagram:** Used to describe interactions among classes in terms of an exchange of messages over time.



<h1 align="center">Design a Hotel Management System</h1>
<h3 align="center">Let's design a Hotel Management System</h3>

**We'll cover the following:**

* [System Requirements](#system-requirements)
* [Use Case Diagram](#use-case-diagram)
* [Class Diagram](#class-diagram)
* [Activity Diagrams](#activity-diagrams)
* [Code](#code)

A Hotel Management System is a software built to handle all online hotel activities easily and safely. This System will give the hotel management power and flexibility to manage the entire system from a single online portal. The system allows the manager to keep track of all the available rooms in the system as well as to book rooms and generate bills.

<p align="center">
    <img src="/media-files/hotel-management-system.png" alt="Hotel Management System">
    <br />
    Hotel Management System
</p>

### System Requirements

We’ll focus on the following set of requirements while designing the Hotel Management System:

1. The system should support the booking of different room types like standard, deluxe, family suite, etc.
2. Guests should be able to search the room inventory and book any available room.
3. The system should be able to retrieve information, such as who booked a particular room, or what rooms were booked by a specific customer.
4. The system should allow customers to cancel their booking - and provide them with a full refund if the cancelation occurs before 24 hours of the check-in date.
5. The system should be able to send notifications whenever the booking is nearing the check-in or check-out date.
6. The system should maintain a room housekeeping log to keep track of all housekeeping tasks.
7. Any customer should be able to add room services and food items.
8. Customers can ask for different amenities.
9. The customers should be able to pay their bills through credit card, check or cash.

### Use Case Diagram

Here are the main Actors in our system:

* **Guest:** All guests can search the available rooms, as well as make a booking.
* **Receptionist:** Mainly responsible for adding and modifying rooms, creating room bookings, check-in, and check-out customers.
* **System:** Mainly responsible for sending notifications for room booking, cancellation, etc.
* **Manager:** Mainly responsible for adding new workers.
* **Housekeeper:** To add/modify housekeeping record of rooms.
* **Server:** To add/modify room service record of rooms.

Here are the top use cases of the Hotel Management System:

* **Add/Remove/Edit room:** To add, remove, or modify a room in the system.
* **Search room:** To search for rooms by type and availability.
* **Register or cancel an account:** To add a new member or cancel the membership of an existing member.
* **Book room:** To book a room.
* **Check-in:** To let the guest check-in for their booking.
* **Check-out:** To track the end of the booking and the return of the room keys.
* **Add room charge:** To add a room service charge to the customer’s bill.
* **Update housekeeping log:** To add or update the housekeeping entry of a room.

Here is the use case diagram of our Hotel Management System:

<p align="center">
    <img src="/media-files/hms-use-case-diagram.svg" alt="Hotel Management System Use Case Diagram">
    <br />
    Use Case Diagram for Hotel Management System
</p>

### Class Diagram

Here are the main classes of our Hotel Management System:

* **Hotel and HotelLocation:** Our system will support multiple locations of a hotel.
* **Room:** The basic building block of the system. Every room will be uniquely identified by the room number. Each Room will have attributes like Room Style, Booking Price, etc.
* **Account:** We will have different types of accounts in the system: one will be a guest to search and book rooms, another will be a receptionist. Housekeeping will keep track of the housekeeping records of a room, and a Server will handle room service.
* **RoomBooking:** This class will be responsible for managing bookings for a room.
* **Notification:** Will take care of sending notifications to guests.
* **RoomHouseKeeping:** To keep track of all housekeeping records for rooms.
* **RoomCharge:** Encapsulates the details about different types of room services that guests have requested.
* **Invoice:** Contains different invoice-items for every charge against the room.
* **RoomKey:** Each room can be assigned an electronic key card. Keys will have a barcode and will be uniquely identified by a key-ID.

<p align="center">
    <img src="/media-files/hms-class-diagram.png" alt="Hotel Management System Class Diagram">
    <br />
    Class Diagram for Hotel Management System
</p>

<p align="center">
    <img src="/media-files/hms-uml.svg" alt="Hotel Management System UML">
    <br />
    UML for Hotel Management System
</p>

### Activity Diagrams

**Make a room booking:** Any guest or receptionist can perform this activity. Here are the set of steps to book a room:

<p align="center">
    <img src="/media-files/hms-room-booking-activity-diagram.svg" alt="Hotel Management System Room Booking">
    <br />
    Activity Diagram for Hotel Management System Room Booking
</p>

**Check in:** Guest will check in for their booking. The Receptionist can also perform this activity. Here are the steps:

<p align="center">
    <img src="/media-files/hms-check-in-activity-diagram.svg" alt="Hotel Management System Check in">
    <br />
    Activity Diagram for Hotel Management System Check in
</p>

**Cancel a booking:** Guest can cancel their booking. Receptionist can perform this activity. Here are the different steps of this activity:

<p align="center">
    <img src="/media-files/hms-cancel-booking-activity-diagram.svg" alt="Hotel Management System Cancel Booking">
    <br />
    Activity Diagram for Hotel Management System Cancel Booking
</p>

### Code

Here is the high-level definition for the classes described above.

**Enums, data types, and constants:** Here are the required enums, data types, and constants:

```python
from enum import Enum


class RoomStyle(Enum):
    STANDARD, DELUXE, FAMILY_SUITE, BUSINESS_SUITE = 1, 2, 3, 4


class RoomStatus(Enum):
    AVAILABLE, RESERVED, OCCUPIED, NOT_AVAILABLE, BEING_SERVICED, OTHER = 1, 2, 3, 4, 5, 6


class BookingStatus(Enum):
    REQUESTED, PENDING, CONFIRMED, CHECKED_IN, CHECKED_OUT, CANCELLED, ABANDONED = 1, 2, 3, 4, 5, 6, 7


class AccountStatus(Enum):
    ACTIVE, CLOSED, CANCELED, BLACKLISTED, BLOCKED = 1, 2, 3, 4, 5


class AccountType(Enum):
    MEMBER, GUEST, MANAGER, RECEPTIONIST = 1, 2, 3, 4


class PaymentStatus(Enum):
    UNPAID, PENDING, COMPLETED, FILLED, DECLINED, CANCELLED, ABANDONED, SETTLING, SETTLED, REFUNDED = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10


class Address:
    def __init__(self, street, city, state, zip_code, country):
        self.__street_address = street
        self.__city = city
        self.__state = state
        self.__zip_code = zip_code
        self.__country = country


```

**Account, Person, Guest, Receptionist, and Server:** These classes represent the different people that interact with our system:

```python
from abc import ABC
from .constants import *


# For simplicity, we are not defining getter and setter functions. The reader can
# assume that all class attributes are private and accessed through their respective
# public getter methods and modified only through their public methods function.

class Account:
    def __init__(self, id, password, status=AccountStatus.Active):
        self.__id = id
        self.__password = password
        self.__status = status

    def reset_password(self):
        None


# from abc import ABC, abstractmethod
class Person(ABC):
    def __init__(self, name, address, email, phone, account):
        self.__name = name
        self.__address = address
        self.__email = email
        self.__phone = phone
        self.__account = account


class Guest(Person):
    def __init__(self):
        self.__total_rooms_checked_in = 0

    def get_bookings(self):
        None


class Receptionist(Person):
    def search_member(self, name):
        None

    def create_booking(self):
        None


class Server(Person):
    def add_room_charge(self, room, room_charge):
        None

```

**Hotel and HotelLocation:** These classes represent the top-level classes of the system:

```python
class HotelLocation:
    def __init__(self, name, address):
        self.__name = name
        self.__location = address

    def get_rooms(self):
        None


class Hotel:
    def __init__(self, name):
        self.__name = name
        self.__locations = []

    def add_location(self, location):
        None

```

**Room, RoomKey, and RoomHouseKeeping:** To encapsulate a room, room key, and housekeeping:

```python
from datetime import datetime
from abc import ABC


class Search(ABC):
    def search(self, style, start_date, duration):
        None


class Room(Search):
    def __init__(self, room_number, room_style, status, price, is_smoking):
        self.__room_number = room_number
        self.__style = room_style
        self.__status = status
        self.__booking_price = price
        self.__is_smoking = is_smoking

        self.__keys = []
        self.__house_keeping_log = []

    def is_room_available(self):
        None

    def check_in(self):
        None

    def check_out(self):
        None

    def search(self, style, start_date, duration):
        None


# return all rooms with the given style and availability


class RoomKey:
    def __init__(self, key_id, barcode, is_active, is_master):
        self.__key_id = key_id
        self.__barcode = barcode
        self.__issued_at = datetime.date.today()
        self.__active = is_active
        self.__is_master = is_master

    def assign_room(self, room):
        None

    def is_active(self):
        None


class RoomHouseKeeping:
    def __init__(self, description, duration, house_keeper):
        self.__description = description
        self.__start_datetime = datetime.date.today()
        self.__duration = duration
        self.__house_keeper = house_keeper

    def add_house_keeping(self, room):
        None

```

**RoomBooking and RoomCharge:** To encapsulate a booking and different charges against a booking:

```python
from datetime import datetime
from abc import ABC


class RoomBooking:
    def __init__(self, reservation_number, start_date, duration_in_days, booking_status):
        self.__reservation_number = reservation_number
        self.__start_date = start_date
        self.__duration_in_days = duration_in_days
        self.__status = booking_status
        self.__checkin = None
        self.__checkout = None

        self.__guest_id = 0
        self.__room = None
        self.__invoice = None
        self.__notifications = []

    def fetch_details(self, reservation_number):
        None


# from abc import ABC, abstractmethod
class RoomCharge(ABC):
    def __init__(self):
        self.__issue_at = datetime.date.today()

    def add_invoice_item(self, invoice):
        None


class Amenity(RoomCharge):
    def __init__(self, name, description):
        self.__name = name
        self.__description = description


class RoomService(RoomCharge):
    def __init__(self, is_chargeable, request_time):
        self.__is_chargeable = is_chargeable
        self.__request_time = request_time


class KitchenService(RoomCharge):
    def __init__(self, description):
        self.__description = description

```

<h1 align="center">Design Stack Overflow</h1>
<h3 align="center">Let's design an online community for developers.</h3>

**We'll cover the following:**

* [System Requirements](#system-requirements)
* [Use Case Diagram](#use-case-diagram)
* [Class Diagram](#class-diagram)
* [Activity Diagram](#activity-diagram)
* [Sequence Diagram](#sequence-diagram)
* [Code](#code)

Stack Overflow is one of the largest online communities for developers to learn and share their knowledge. The website provides a platform for its users to ask and answer questions, and through membership and active participation, to vote questions and answers up or down. Users can edit questions and answers in a fashion similar to a [wiki](https://en.wikipedia.org/wiki/Wiki).

Users of Stack Overflow can earn reputation points and badges. For example, a person is awarded ten reputation points for receiving an “up” vote on an answer and five points for the “up” vote of a question. The can also receive badges for their valued contributions. A higher reputation lets users unlock new privileges like the ability to vote, comment on, and even edit other people’s posts.

<p align="center">
    <img src="/media-files/stack-overflow.jpg" alt="Stack Overflow">
    <br />
    Stack Overflow - Online Community for Developers
</p>

### System Requirements

We will be designing a system with the following requirements:

1. Any non-member (guest) can search and view questions. However, to add or upvote a question, they have to become a member.
2. Members should be able to post new questions.
3. Members should be able to add an answer to an open question.
4. Members can add comments to any question or answer.
5. A member can upvote a question, answer or comment.
6. Members can flag a question, answer or comment, for serious problems or moderator attention.
7. Any member can add a [bounty](https://stackoverflow.com/help/bounty) to their question to draw attention.
8. Members will earn [badges](https://stackoverflow.com/help/badges) for being helpful.
9. Members can vote to [close](https://stackoverflow.com/help/closed-questions) a question; Moderators can close or reopen any question.
10. Members can add [tags](https://stackoverflow.com/help/tagging) to their questions. A tag is a word or phrase that describes the topic of the question.
11. Members can vote to [delete](https://stackoverflow.com/help/deleted-questions) extremely off-topic or very low-quality questions.
12. Moderators can close a question or undelete an already deleted question.
13. The system should also be able to identify most frequently used tags in the questions.

### Use Case Diagram

We have five main actors in our system:

* **Admin:** Mainly responsible for blocking or unblocking members.
* **Guest:** All guests can search and view questions.
* **Member:** Members can perform all activities that guests can, in addition to which they can add/remove questions, answers, and comments. Members can delete and un-delete their questions, answers or comments.
* **Moderator:** In addition to all the activities that members can perform, moderators can close/delete/undelete any question.
* **System:** Mainly responsible for sending notifications and assigning badges to members.

Here are the top use cases for Stack Overflow:

1. Search questions.
2. Create a new question with bounty and tags.
3. Add/modify answers to questions.
4. Add comments to questions or answers.
5. Moderators can close, delete, and un-delete any question.

Here is the use case diagram of Stack Overflow:

<p align="center">
    <img src="/media-files/stack-overflow-use-case.svg" alt="Stack Overflow Use Case Diagram">
    <br />
    Use Case Diagram for Stack Overflow
</p>

### Class Diagram

Here are the main classes of Stack Overflow System:

* **Question:** This class is the central part of our system. It has attributes like Title and Description to define the question. In addition to this, we will track the number of times a question has been viewed or voted on. We should also track the status of a question, as well as closing remarks if the question is closed.
* **Answer:** The most important attributes of any answer will be the text and the view count. In addition to that, we will also track the number of times an answer is voted on or flagged. We should also track if the question owner has accepted an answer.
* **Comment:** Similar to answer, comments will have text, and view, vote, and flag counts. Members can add comments to questions and answers.
* **Tag:** Tags will be identified by their names and will have a field for a description to define them. We will also track daily and weekly frequencies at which tags are associated with questions.
* **Badge:** Similar to tags, badges will have a name and description.
* **Photo:** Questions or answers can have photos.
* **Bounty:** Each member, while asking a question, can place a bounty to draw attention. Bounties will have a total reputation and an expiry date.
* **Account:** We will have four types of accounts in the system, guest, member, admin, and moderator. Guests can search and view questions. Members can ask questions and earn reputation by answering questions and from bounties.
* **Notification:** This class will be responsible for sending notifications to members and assigning badges to members based on their reputations.

<p align="center">
    <img src="/media-files/stack-overflow-class-diagram.svg" alt="Stack Overflow Class Diagram">
    <br />
    Class Diagram for Stack Overflow
</p>

<p align="center">
    <img src="/media-files/stack-overflow-uml.svg" alt="Stack Overflow UML">
    <br />
    UML for Stack Overflow
</p>

### Activity Diagram

**Post a new question:** Any member or moderator can perform this activity. Here are the steps to post a question:

<p align="center">
    <img src="/media-files/stack-overflow-activity-diagram.svg" alt="Stack Overflow Activity Diagram">
    <br />
    Activity Diagram for Stack Overflow
</p>

### Sequence Diagram

Following is the sequence diagram for creating a new question:

<p align="center">
    <img src="/media-files/stack-overflow-sequence-diagram.svg" alt="Stack Overflow Sequence Diagram">
    <br />
    Sequence Diagram for Stack Overflow
</p>

### Code

Here is the high-level definition for the classes described above.

**Enums, data types, and constants:** Here are the required enums, data types, and constants:

```python
from enum import Enum


class QuestionStatus(Enum):
    OPEN, CLOSED, ON_HOLD, DELETED = 1, 2, 3, 4


class QuestionClosingRemark(Enum):
    DUPLICATE, OFF_TOPIC, TOO_BROAD, NOT_CONSTRUCTIVE, NOT_A_REAL_QUESTION, PRIMARILY_OPINION_BASED = 1, 2, 3, 4, 5, 6


class AccountStatus(Enum):
    ACTIVE, CLOSED, CANCELED, BLACKLISTED, BLOCKED = 1, 2, 3, 4, 5


```

**Account, Member, Admin, and Moderator:** These classes represent the different people that interact with our system:

```python
from .constants import *


# For simplicity, we are not defining getter and setter functions. The reader can
# assume that all class attributes are private and accessed through their respective
# public getter methods and modified only through their public methods function.


class Account:
    def __init__(self, id, password, name, address, email, phone, status=AccountStatus.Active):
        self.__id = id
        self.__password = password
        self.__name = name
        self.__address = address
        self.__email = email
        self.__phone = phone
        self.__status = status
        self.__reputation = 0

    def reset_password(self):
        None


class Member:
    def __init__(self, account):
        self.__account = account
        self.__badges = []

    def get_reputation(self):
        return self.__account.get_reputation()

    def get_email(self):
        return self.__account.get_email()

    def create_question(self, question):
        None

    def create_tag(self, tag):
        None


class Admin(Member):
    def block_member(self, member):
        None

    def unblock_member(self, member):
        None


class Moderator(Member):
    def close_question(self, question):
        None

    def undelete_question(self, question):
        None


```

**Badge, Tag, and Notification:** Members have badges, questions have tags and notifications:

```python
from datetime import datetime


class Badge:
    def __init__(self, name, description):
        self.__name = name
        self.__description = description


class Tag:
    def __init__(self, name, description):
        self.__name = name
        self.__description = description
        self.__daily_asked_frequency = 0
        self.__weekly_asked_frequency = 0


class Notification:
    def __init__(self, id, content):
        self.__notification_id = id
        self.__created_on = datetime.datetime.now()
        self.__content = content
    
    def send_notification(self):
        None


```

**Photo and Bounty:** Members can put bounties on questions. Answers and Questions can have multiple photos:

```python
from datetime import datetime

class Photo:
    def __init__(self, id, path, member):
        self.__photo_id = id
        self.__photo_path = path
        self.__creation_date = datetime.now()
        self.__creating_member = member
    
    def delete(self):
        None


class Bounty:
    def __init__(self, reputation, expiry):
        self.__reputation = reputation
        self.__expiry = expiry
    
    def modify_reputation(self, reputation):
        None


```

**Question, Comment and Answer:** Members can ask questions, as well as add an answer to any question. All members can add comments to all open questions or answers:

```python
from datetime import datetime
from abc import ABC
from .constants import *

class Search(ABC):
    def search(self, query):
        None


class Question(Search):
    def __init__(self, title, description, bounty, asking_member):
        self.__title = title
        self.__description = description
        self.__view_count = 0
        self.__vote_count = 0
        self.__creation_time = datetime.now()
        self.__update_time = datetime.now()
        self.__status = QuestionStatus.OPEN
        self.__closing_remark = QuestionClosingRemark.DUPLICATE

        self.__bounty = bounty
        self.__asking_member = asking_member
        self.__photos = []
        self.__comments = []
        self.__answers = []

    def close(self):
        None

    def undelete(self):
        None

    def add_comment(self, comment):
        None

    def add_bounty(self, bounty):
        None

    def search(self, query):
        # return all questions containing the string query in their title or description.
        None


class Comment:
    def __init__(self, text, member):
        self.__text = text
        self.__creation_time = datetime.now()
        self.__flag_count = 0
        self.__vote_count = 0
        self.__asking_member = member

    def increment_vote_count(self):
        None


class Answer:
    def __init__(self, text, member):
        self.__answer_text = text
        self.__accepted = False
        self.__vote_count = 0
        self.__flag_count = 0
        self.__creation_time = datetime.now()
        self.__creating_member = member
        self.__photos = []

    def increment_vote_count(self):
        None


```



