using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 60)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.0.5148")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_wd8iaa
{
	[FieldOffset(0)]
	public InlineArray3_fputil_ExceptValues_float_6_Mapping values;
}
