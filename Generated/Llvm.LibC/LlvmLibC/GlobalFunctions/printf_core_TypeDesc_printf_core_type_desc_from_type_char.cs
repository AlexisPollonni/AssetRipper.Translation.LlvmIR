using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core19type_desc_from_typeIPcEENS0_8TypeDescEv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc __llvm_libc_20_1_2_::printf_core::type_desc_from_type<char*>()")]
internal static partial class printf_core_TypeDesc_printf_core_type_desc_from_type_char
{
	public unsafe static short Invoke()
	{
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 1;
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = 0;
		printf_core_TypeDesc2.size = 8;
		printf_core_TypeDesc2.primary_type = PrimaryType.Pointer;
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		return *unchecked((short*)(&printf_core_TypeDesc2));
	}
}
