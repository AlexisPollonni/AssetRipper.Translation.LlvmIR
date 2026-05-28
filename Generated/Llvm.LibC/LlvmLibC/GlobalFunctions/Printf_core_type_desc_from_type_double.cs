using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_type_desc_from_type_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core19type_desc_from_typeIdEENS0_8TypeDescEv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc __llvm_libc_20_1_2_::printf_core::type_desc_from_type<double>()")]
	[return: NativeType("__llvm_libc_20_1_2_::printf_core::TypeDesc")]
	public unsafe static short Invoke()
	{
		Printf_core_TypeDesc printf_core_TypeDesc = default(Printf_core_TypeDesc);
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 1;
		Llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = 0;
		printf_core_TypeDesc.Size = 8;
		printf_core_TypeDesc.Primary_type = PrimaryType.Float;
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		return *unchecked((short*)(&printf_core_TypeDesc));
	}
}
