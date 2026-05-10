using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core19type_desc_from_typeIvEENS0_8TypeDescEv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc __llvm_libc_20_1_2_::printf_core::type_desc_from_type<void>()")]
[CleanName("printf_core_TypeDesc_printf_core_type_desc_from_type_void")]
internal static partial class printf_core_TypeDesc_printf_core_type_desc_from_type_void_kvifr8
{
	public unsafe static short Invoke()
	{
		printf_core_TypeDesc printf_core_TypeDesc2 = new printf_core_TypeDesc
		{
			size = 0,
			primary_type = 0
		};
		return *unchecked((short*)(&printf_core_TypeDesc2));
	}
}
