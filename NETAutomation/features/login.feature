Feature: Login in to automation exercise

@mytag
Scenario: Login correctly
    Given the user starts the app
    When user navigates to "Signup/Login"
    And user set email "mytest@test.com"
    And user set password "mytest12345"
    And user clicks login button
    Then logout is visible
