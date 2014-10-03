<Query Kind="Statements">
  <Connection>
    <ID>abf60b9f-928a-4aea-9b73-facf12da2f12</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Select all basics
var entity1 = from anItem in SpecialEvents 
select anItem;

entity1.Dump("Entity1");

//Select just code and desc
var entity2 = from anItem in SpecialEvents
select new 
{
	anItem.EventCode, 
	anItem.Description
};

entity2.Dump("Entity2");
entity2.Count().Dump("Count of instances");

//Select just the reservations with eventcode equal to B
var entity3 = from anItem in Reservations
where anItem.EventCode.Equals("B")
select anItem;

entity3.Dump("Entity3");

//Special Events Code & Description ordered descending by Description
var entity4 = from anItem in SpecialEvents
orderby anItem.Description descending
select new
{
	anItem.EventCode,
	anItem.Description
};

entity4.Dump("Entity4");

//Select CustomerName by EventCode equal to S. Ordered by Number in Party then Customer Name
var entity5 = from anItem in Reservations
where anItem.SpecialEvents.EventCode.Equals("S") && ((DateTime.Today.AddDays(-23) > anItem.ReservationDate) 
	&& (DateTime.Today.AddDays(-31) < anItem.ReservationDate))
orderby anItem.NumberInParty, anItem.CustomerName
select new
{
	anItem.CustomerName,
	anItem.NumberInParty,
	ResDate = string.Format("{0:MMM dd, yyyy}", anItem.ReservationDate),
	anItem.SpecialEvents.Description
};

entity5.Dump("Entity5");

