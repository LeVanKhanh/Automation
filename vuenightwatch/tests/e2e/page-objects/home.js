module.exports = {
    url:'http://localhost:8080',
    elements: {
        linkVueCliDocumentation:{
            selector: '//*[@id="app"]/div/p/a',
            locateStrategy: 'xpath'
        }
    },
    commands: [{
        goToCliDocumentation: function(){
            this.api.pause(2000);
            return this.navigate()
                        .waitForElementVisible("@linkVueCliDocumentation", 2000)
                        .click("@linkVueCliDocumentation")
                        .pause(2000);
        }
    }]
}