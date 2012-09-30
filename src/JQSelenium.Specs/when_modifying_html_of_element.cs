﻿using Machine.Specifications;

namespace JQSelenium.Specs
{
    internal class when_modifying_html_of_element : given_a_jquery_factory_context
    {
        static JQuerySelector _jQuerySelector;
        static JQueryTag _jQueryTag;
        static string _expectedHtml;

        Establish load_context = () =>
            {
                _jQuerySelector = jQueryFactory.Query("h1");
                _jQueryTag = _jQuerySelector.Get();
                _expectedHtml = "<p>TestHTML</p>";
            };

        Because of = () => _jQueryTag.html(_expectedHtml);

        It should_modify_hmtl_of_element = () => _jQueryTag.html().ShouldEqual(_expectedHtml);
    }
}