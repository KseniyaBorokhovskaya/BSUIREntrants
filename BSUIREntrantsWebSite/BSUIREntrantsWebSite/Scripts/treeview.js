$('#treeview').jstree({
    "plugins": ["search", "wholerow"],
    'core': {
        'data': {
            'url': function (node) {
                return node.id === '#' ? "/UniversityTreeController/GetRoot" : "/UniversityTreeController/GetChildren/" + node.id;

            },
            'data': function (node) {
                return { 'id': node.id };
            }
        }
    }
});

$('#treeview').on('changed.jstree', function (e, data) {
    console.log("=> selected node: " + data.node.id);
});