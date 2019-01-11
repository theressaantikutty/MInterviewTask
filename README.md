# Junior-Developer-Interview-Task
Junior Developer Interview Task


Task
We would like you to demonstrate your development skills by delivering a single page web site based on a set of requirements that match the way we deliver solutions within our team.

Please timebox your work on this. We don't expect this task should take longer than 2 hours.
You will need a GitHub account to clone this repository (mariecurie-interview-scenarios)
Once you have finished, send us a Dropbox/Skydrive/whatever link to your zipped code to us.
=======

During the face-to-face interview we would like to discuss your solution and your approach. We will expect you to demonstrate how the acceptance criteria have been met and also any challenges you faced during development.

If you have any questions, please get in touch.

Good luck :)

Background
The Marie Curie Caring Services department wish to better promote their Helper service on the charity's website.

The Helper Service matches trained volunteers with people living with a terminal illness and provides support to them or their families. Support is provided free of charge and is available to people aged 18 or over with any terminal illness, and their families

The Website Scrum team Product Owner and Business Analyst have agreed with the Caring Services team that a page will be developed for the website that will list out available Helper Services; show how they can be contacted and dynamically highlight if and when they can be contacted.

User Story
The following user story and acceptance criteria was created and will be used by the team to design and validate their work.

"As a website user who needs help and support I want to be able to find Helper Services so that I know what support is available to me and how to contact them"

Background: GIVEN I am on the Marie Curie website

WHEN I view the Helper Service page

AC1: Display

THEN I want to see a list that contains all Marie Curie Helper Services

AC2: Detail

THEN each Helper Service list item will have the following properties: Title - linked to a page (https://www.mariecurie.org.uk/help/helper-volunteers), Description, Telephone number and a currently open / closed status

AC3: Dynamic status

THEN I want to see whether the helpline is OPEN or CLOSED with the label copy as per below

OPEN - OPEN TODAY UNTIL {closing time}

CLOSED - REOPENS {day} at {opening time}

AC4: Visual

THEN the Helper Service list item displays a clear visual representation of whether it is the service is open or closed

Note: Full details of this visual representation required is given in the wireframe / annotations

AC5: Telephone

THEN when I am using a mobile device, I should be able to tap the number to call the number.

Technical Brief
The team has discussed the user story and has provided the following guidance and assets to help you complete the story.

Stack
Marie Curie's modern web stack runs using ASP.NET 4.5.1

Integration
Helper Service information is mastered in a back office CRM system and made available via a C# library built using ASP.NET 4.5.1. A fellow developer has already included this library in a Nuget package in the repository for you.
