reagent-effect-condition-guidebook-erpstatus = 
    { $shouldHave ->
        [true] усваивается только
       *[false] не усваивается только
    } { $erp ->
       *[0] при отказе от ЕРП
        [1] при неполном ЕРП
        [2] при полном ЕРП
    }
