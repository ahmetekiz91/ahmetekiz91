<template>
    <div class="action-buttons">
        <button class="btn btn-outline-success" @click="handleAction('view')">
            <i class="fa fa-eye"></i>
        </button>
        <button class="btn btn-outline-primary" @click="handleAction('edit')" data-toggle="modal" data-target="#modal-xl">
            <i class="fa fa-edit"></i>
        </button>
        <button class="btn btn-outline-dark" @click="handleAction('delete')">
            <i class="fa fa-trash"></i>
        </button>
    </div>
</template>
<script>
export default {
    name: "ActionButtons",
    methods: {
    
      
    },
    props: {
        data: {
            type: Object,
            required: true,
        },
    },
};
</script>
