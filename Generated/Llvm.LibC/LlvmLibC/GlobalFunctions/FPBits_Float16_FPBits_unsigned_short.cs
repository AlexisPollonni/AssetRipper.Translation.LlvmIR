using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_Float16_FPBits_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIDF16_EC2ItEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>::FPBits<unsigned short>(unsigned short)")]
	public unsafe static void Invoke(fputil_FPBits_2fahva* @this, [NativeType("unsigned short")] short x)
	{
		short field_ = x;
		unchecked
		{
			FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_Constructor.Invoke((fputil_internal_FPRepImpl_7z3gh9*)@this);
			((fputil_internal_FPStorage_za9n4f*)@this)->field_0 = field_;
		}
	}
}
