using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 160)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.5146")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_669x8w
{
	[FieldOffset(0)]
	public InlineArray8_fputil_ExceptValues_float_6_Mapping values;
}
