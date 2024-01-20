Feature: Login

Scenario: User can log in with valid credentials
    Given the user is on the login page
    When the user enters valid credentials
    And clicks on the "Login" button
    Then the user should be redirected to the dashboard page

Scenario: User cannot log in with invalid credentials
    Given the user is on the login page
    When the user enters invalid credentials
    And clicks on the "Login" button
    Then an error message should be displayed
