function AmountOfChildren({ formData, setFormData }) {
    const single_child_data = () => {
        setFormData({
            ...formData,
            
            singleChild: true,
            multiplechildren: false,
            AmountOfChildren: 1
        });
    }
    const multiple_child_data = () => {
        setFormData({
            ...formData,
            singleChild:false,
            multiplechildren: true
            
        });
    }
    const amount_children_data = (e) => {
        setFormData({
            ...formData,
            AmountOfChildren: e.target.value
        });
    }
    return (
        <div>
            <form method="post">
                <p>vælg om det er enebørn eller tvillinger</p>
                <input type="radio" name="amount_of_children" id="single_child" value="true" checked={formData.singleChild} onChange={single_child_data } required/>
                <label htmlFor="single_child">ene barn </label><br />
                <input type="radio" name="amount_of_children" id="multiple_children" value="false" checked={formData.multiplechildren} onChange={multiple_child_data} required/>
                <label htmlFor="multiple_children">flere børn</label>
                <div> {formData.multiplechildren && (<div><input type="number" name="amount_of_children" min="2" defaultValue={2} onChange={amount_children_data } /> <label htmlFor="amount_of_children">vælg antallet af børn</label> </div>)}</div>
               
            </form>
        </div>
    )
}

export default AmountOfChildren;
