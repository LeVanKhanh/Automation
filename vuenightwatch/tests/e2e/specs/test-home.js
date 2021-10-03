module.exports = {
    'step one: navigate to vue-cli documentation': function(browser) {
     const homePageObject = browser.page.home();
     console.log(homePageObject)
     homePageObject.goToCliDocumentation();
    },
  };