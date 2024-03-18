Feature: Login in to automation exercise

    @Regression
    Scenario: Login correctly
        Given the user starts the app
        When user navigates to "Signup / Login"
        And user set email "Mytest@test.com"
        And user set password "mytest12345"
        And user clicks login button
        Then logout is visible