# Booking System

A modular booking platform for managing hotels, arenas, restaurants, sports facilities and activities.

The system supports:

- hotel room bookings
- tennis court reservations
- restaurant reservations
- excursions and activities
- arena events with seat ticketing

## Architecture

The system follows a domain-driven design inspired architecture.

Core layers:

BookingSystem.Api
BookingSystem.Domain
BookingSystem.Infrastructure

## Domain Concepts

Company
Property (Hotel / Arena)
Customer
Stay
BookableUnit
ServiceOffer
ActivityOffer
Booking
Event
SeatSection
Seat
Ticket