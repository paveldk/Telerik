$.fn.gallery = function (columns) {
    var $galery = $(this).addClass('gallery')
    	.on('click', '.image-container', imageClick),
    	columns = columns || 4,
    	$images = $galery.find(".image-container")
    		.width(($galery.width()/columns)-12)
    		.height(($galery.width()/columns)-12);
    		
   
    $galery.find(".current-image").empty()
    	.on('click', currentImageClick);
    $galery.find(".previous-image").empty()
    	.on('click', previousImageClick);
    $galery.find(".next-image").empty()
    	.on('click', nextImageClick);

    function imageClick() {
    	var $this = $(this),
    		$currentImage = $(this).children().clone(),
   			$previousImage,
   			$nextImage;

   		if ($this.is($this.parent().children().first())) {
   			$previousImage = $this.parent().children().last().children().clone();
   		}
   		else {
			$previousImage = $this.prev().children().clone();
   		}

   		if ($this.is($this.parent().children().last())) {
   			$nextImage = $this.parent().children().first().children().clone();
   		}
   		else {
			$nextImage = $this.next().children().clone();
   		}

   		$galery.find(".gallery-list").addClass('blurred').addClass('disabled-background');
   		$galery.off('click', '.image-container', imageClick);

    	$galery.find(".current-image").empty();
    	$galery.find(".previous-image").empty();
    	$galery.find(".next-image").empty();
    	
    	$galery.find(".current-image").html($currentImage);
    	$galery.find(".previous-image").html($previousImage);
    	$galery.find(".next-image").html($nextImage);
    }

    function currentImageClick() {
    	$galery.on('click', '.image-container', imageClick);
    	$galery.find(".gallery-list").removeClass('blurred').removeClass('disabled-background');

    	$galery.find(".current-image").empty();
    	$galery.find(".previous-image").empty();
    	$galery.find(".next-image").empty();
    }

    function previousImageClick () {
    	var $this = $(this),
    		$newCurrent = $(this).children().clone();
    		$newNext = $galery.find(".current-image").children().clone(),
    		currentDataInfo = $newCurrent.attr('data-info');

    	$galery.find(".current-image").empty();
    	$galery.find(".previous-image").empty();
    	$galery.find(".next-image").empty();

    	$galery.find(".current-image").html($newCurrent);
    	$galery.find(".next-image").html($newNext);


		var $oldPrevious = $galery.find('.image-container').find("[data-info='" + parseInt(currentDataInfo) + "']").parent();
		
		if ($oldPrevious.is($galery.find('.gallery-list').children().first())) {
   			var $newPrevious = $oldPrevious.parent().children().last().children().clone();
   		} else {
   			var $newPrevious = $oldPrevious.prev().children().clone();
   		}

   		$galery.find(".previous-image").html($newPrevious);
    }


    function nextImageClick () {
    	var $this = $(this),
    		$newCurrent = $(this).children().clone();
    		$newPrevious = $galery.find(".current-image").children().clone(),
    		currentDataInfo = $newCurrent.attr('data-info');

    	$galery.find(".current-image").empty();
    	$galery.find(".previous-image").empty();
    	$galery.find(".next-image").empty();

    	$galery.find(".current-image").html($newCurrent);
    	$galery.find(".previous-image").html($newPrevious);

		var $oldNext = $galery.find('.image-container').find("[data-info='" + currentDataInfo + "']").parent();
		
		if ($oldNext.is($galery.find('.gallery-list').children().last())) {
   			var $newNext = $oldNext.parent().children().first().children().clone();
   		} else {
   			var $newNext = $oldNext.next().children().clone();
   		}

   		$galery.find(".next-image").html($newNext);
    }
};