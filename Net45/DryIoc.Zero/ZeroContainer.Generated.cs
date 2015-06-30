﻿

using System;
using System.Linq; // for Enumerable.Cast method required for LazyEnumerable<T>
using System.Collections.Generic;

namespace DryIoc.Zero
{
    partial class ZeroContainer
    {
/* 
Exceptions happened during resolution:
======================================

DryIoc.ContainerException:
Unable to resolve DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface {ServiceKey=DefaultKey.Of(0)}
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface, ServiceKey=DefaultKey.Of(0)}
Where CurrentScope=null
  and ResolutionScope=null
Found registrations:
  {DefaultKey.Of(0), {ID=42, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}
  {DefaultKey.Of(1), {ID=43, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}
  {DefaultKey.Of(2), {ID=44, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}


DryIoc.ContainerException:
Unable to resolve DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface {ServiceKey=DefaultKey.Of(1)}
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface, ServiceKey=DefaultKey.Of(1)}
Where CurrentScope=null
  and ResolutionScope=null
Found registrations:
  {DefaultKey.Of(0), {ID=42, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}
  {DefaultKey.Of(1), {ID=43, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}
  {DefaultKey.Of(2), {ID=44, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}


DryIoc.ContainerException:
Unable to resolve DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface {ServiceKey=DefaultKey.Of(2)}
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.IExportConditionInterface, ServiceKey=DefaultKey.Of(2)}
Where CurrentScope=null
  and ResolutionScope=null
Found registrations:
  {DefaultKey.Of(0), {ID=42, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}
  {DefaultKey.Of(1), {ID=43, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}
  {DefaultKey.Of(2), {ID=44, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3, Reuse=SingletonReuse {Lifespan=1000}, HasCondition}}


DryIoc.ContainerException:
Unable to resolve wrapper DryIoc.Meta<Lazy<DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool>, DryIoc.MefAttributedModel.UnitTests.CUT.MineMeta> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool} as parameter "tool"
  in DryIoc.MefAttributedModel.UnitTests.CUT.MyCode
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.MyCode}.
Please register service or add Rules.WithUnknownServiceResolver(...).

DryIoc.ContainerException:
Unable to resolve String as parameter "message"
  in DryIoc.MefAttributedModel.UnitTests.CUT.OneTransientService: DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations {ServiceKey=DefaultKey.Of(0)}
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations, ServiceKey=DefaultKey.Of(0)}.
Please register service or add Rules.WithUnknownServiceResolver(...).

DryIoc.ContainerException:
Unable to resolve String as parameter "message"
  in DryIoc.MefAttributedModel.UnitTests.CUT.AnotherTransientService: DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations {ServiceKey=DefaultKey.Of(1)}
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMultipleImplentations, ServiceKey=DefaultKey.Of(1)}.
Please register service or add Rules.WithUnknownServiceResolver(...).

DryIoc.ContainerException:
Unable to resolve String as parameter "message"
  in DryIoc.MefAttributedModel.UnitTests.CUT.Two
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.Two}.
Please register service or add Rules.WithUnknownServiceResolver(...).

DryIoc.MefAttributedModel.AttributedModelException:
Unable to find single constructor with System.ComponentModel.Composition.ImportingConstructorAttribute in DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructors.

DryIoc.ContainerException:
Unable to resolve DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool
  in wrapper Func<String, DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool} as parameter "getTool"
  in DryIoc.MefAttributedModel.UnitTests.CUT.HomeUser
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.HomeUser}
Where CurrentScope=null
  and ResolutionScope=null
Found registrations:
  {13, {ID=110, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool, Reuse=SingletonReuse {Lifespan=1000}}}


DryIoc.ContainerException:
Unable to resolve String as parameter "message"
  in DryIoc.MefAttributedModel.UnitTests.CUT.FactoryWithArgsConsumer
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.FactoryWithArgsConsumer}.
Please register service or add Rules.WithUnknownServiceResolver(...).

DryIoc.ContainerException:
Unable to resolve DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool as parameter "tool"
  in DryIoc.MefAttributedModel.UnitTests.CUT.WithUnregisteredExternalEdependency
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.WithUnregisteredExternalEdependency}
Where CurrentScope=null
  and ResolutionScope=null
Found registrations:
  {13, {ID=110, ImplType=DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool, Reuse=SingletonReuse {Lifespan=1000}}}


DryIoc.ContainerException:
Unable to resolve String as parameter "message"
  in DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithPrimitiveParameter
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithPrimitiveParameter}.
Please register service or add Rules.WithUnknownServiceResolver(...).

DryIoc.MefAttributedModel.AttributedModelException:
Unable to resolve dependency DryIoc.MefAttributedModel.UnitTests.CUT.IFooService with metadata [NotFound] in DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumerNotFound
  in wrapper DryIoc.FactoryExpression<Object> {RequiredServiceType=DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumerNotFound}

======================================
end of exception list
*/
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public object ResolveGenerated(Type serviceType, IScope scope)
        {
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty))
                return Create_1(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBase))
                return Create_2(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool))
                return Create_3(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer))
                return Create_4(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory))
                return Create_9(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me))
                return Create_10(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep))
                return Create_18(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser))
                return Create_25(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport))
                return Create_30(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ITransientService))
                return Create_33(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory))
                return Create_34(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISingletonService))
                return Create_35(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports))
                return Create_41(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool))
                return Create_42(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2))
                return Create_45(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService))
                return Create_51(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory))
                return Create_52(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AppleFactory))
                return Create_53(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter))
                return Create_55(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb))
                return Create_56(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooHey))
                return Create_57(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty))
                return Create_58(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory))
                return Create_60(this, scope);
            if (serviceType == typeof(System.Func<string, DryIoc.MefAttributedModel.UnitTests.CUT.Orange>))
                return Create_61(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult))
                return Create_62(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient))
                return Create_63(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1))
                return Create_65(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumer))
                return Create_66(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IForExport))
                return Create_69(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable))
                return Create_70(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DependentService))
                return Create_71(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory))
                return Create_72(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory))
                return Create_76(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata))
                return Create_78(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAnotherDb))
                return Create_79(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient))
                return Create_80(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Service))
                return Create_81(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3))
                return Create_82(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan))
                return Create_83(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah))
                return Create_85(this, scope);
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructorsAndOneImporting))
                return Create_88(this, scope);
            return null;
        }

        public object ResolveGenerated(Type serviceType, object serviceKey, IScope scope)
        {
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_5(this, scope);
                if (DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.One.Equals(serviceKey))
                    return Create_6(this, scope);
                if (DefaultKey.Of(1).Equals(serviceKey))
                    return Create_7(this, scope);
                if (DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne.Equals(serviceKey))
                    return Create_8(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler)) 
            {
                if ("transact".Equals(serviceKey))
                    return Create_11(this, scope);
                if ("slow".Equals(serviceKey))
                    return Create_12(this, scope);
                if ("fast".Equals(serviceKey))
                    return Create_13(this, scope);
                if (DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Blah.Equals(serviceKey))
                    return Create_14(this, scope);
                if (DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh.Equals(serviceKey))
                    return Create_15(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_16(this, scope);
                if (DefaultKey.Of(1).Equals(serviceKey))
                    return Create_17(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported)) 
            {
                if ("c".Equals(serviceKey))
                    return Create_19(this, scope);
                if ("j".Equals(serviceKey))
                    return Create_20(this, scope);
                if ("i".Equals(serviceKey))
                    return Create_21(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_22(this, scope);
                if (DefaultKey.Of(1).Equals(serviceKey))
                    return Create_23(this, scope);
                if (DefaultKey.Of(2).Equals(serviceKey))
                    return Create_24(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler)) 
            {
                if ("fast".Equals(serviceKey))
                    return Create_26(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported)) 
            {
                if ("c".Equals(serviceKey))
                    return Create_27(this, scope);
                if ("b".Equals(serviceKey))
                    return Create_28(this, scope);
                if ("a".Equals(serviceKey))
                    return Create_29(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOne)) 
            {
                if ("blah".Equals(serviceKey))
                    return Create_31(this, scope);
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_32(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_36(this, scope);
                if (DefaultKey.Of(1).Equals(serviceKey))
                    return Create_37(this, scope);
                if (DefaultKey.Of(2).Equals(serviceKey))
                    return Create_38(this, scope);
                if ("orange".Equals(serviceKey))
                    return Create_39(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample)) 
            {
                if (1.Equals(serviceKey))
                    return Create_40(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One)) 
            {
                if ("two".Equals(serviceKey))
                    return Create_43(this, scope);
                if ("one".Equals(serviceKey))
                    return Create_44(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_46(this, scope);
                if ("apple".Equals(serviceKey))
                    return Create_47(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed)) 
            {
                if ("blah".Equals(serviceKey))
                    return Create_48(this, scope);
                if ("named".Equals(serviceKey))
                    return Create_49(this, scope);
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_50(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler)) 
            {
                if (DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh.Equals(serviceKey))
                    return Create_54(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler)) 
            {
                if ("transact".Equals(serviceKey))
                    return Create_59(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService)) 
            {
                if (DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne.Equals(serviceKey))
                    return Create_64(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamedService)) 
            {
                if ("blah".Equals(serviceKey))
                    return Create_67(this, scope);
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_68(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPrintToCode)) 
            {
                if (1.Equals(serviceKey))
                    return Create_73(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_74(this, scope);
                if (DefaultKey.Of(1).Equals(serviceKey))
                    return Create_75(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne)) 
            {
                if ("blah".Equals(serviceKey))
                    return Create_77(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler)) 
            {
                if ("slow".Equals(serviceKey))
                    return Create_84(this, scope);
            }
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    return Create_86(this, scope);
                if (DefaultKey.Of(1).Equals(serviceKey))
                    return Create_87(this, scope);
            }
            return null;
        }

        public IEnumerable<KV> ResolveManyGenerated(Type serviceType)
        {
            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_1);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBase))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_2);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_3);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_4);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IService))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_5);
                yield return new KV(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.One, (StatelessFactoryDelegate)Create_6);
                yield return new KV(DefaultKey.Of(1), (StatelessFactoryDelegate)Create_7);
                yield return new KV(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne, (StatelessFactoryDelegate)Create_8);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_9);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_10);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IHandler))
            {
                yield return new KV("transact", (StatelessFactoryDelegate)Create_11);
                yield return new KV("slow", (StatelessFactoryDelegate)Create_12);
                yield return new KV("fast", (StatelessFactoryDelegate)Create_13);
                yield return new KV(DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Blah, (StatelessFactoryDelegate)Create_14);
                yield return new KV(DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, (StatelessFactoryDelegate)Create_15);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_16);
                yield return new KV(DefaultKey.Of(1), (StatelessFactoryDelegate)Create_17);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_18);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IMultiExported))
            {
                yield return new KV("c", (StatelessFactoryDelegate)Create_19);
                yield return new KV("j", (StatelessFactoryDelegate)Create_20);
                yield return new KV("i", (StatelessFactoryDelegate)Create_21);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IServiceWithMetadata))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_22);
                yield return new KV(DefaultKey.Of(1), (StatelessFactoryDelegate)Create_23);
                yield return new KV(DefaultKey.Of(2), (StatelessFactoryDelegate)Create_24);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_25);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler))
            {
                yield return new KV("fast", (StatelessFactoryDelegate)Create_26);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported))
            {
                yield return new KV("c", (StatelessFactoryDelegate)Create_27);
                yield return new KV("b", (StatelessFactoryDelegate)Create_28);
                yield return new KV("a", (StatelessFactoryDelegate)Create_29);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_30);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IOne))
            {
                yield return new KV("blah", (StatelessFactoryDelegate)Create_31);
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_32);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ITransientService))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_33);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_34);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISingletonService))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_35);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Orange))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_36);
                yield return new KV(DefaultKey.Of(1), (StatelessFactoryDelegate)Create_37);
                yield return new KV(DefaultKey.Of(2), (StatelessFactoryDelegate)Create_38);
                yield return new KV("orange", (StatelessFactoryDelegate)Create_39);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample))
            {
                yield return new KV(1, (StatelessFactoryDelegate)Create_40);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_41);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_42);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.One))
            {
                yield return new KV("two", (StatelessFactoryDelegate)Create_43);
                yield return new KV("one", (StatelessFactoryDelegate)Create_44);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_45);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Apple))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_46);
                yield return new KV("apple", (StatelessFactoryDelegate)Create_47);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamed))
            {
                yield return new KV("blah", (StatelessFactoryDelegate)Create_48);
                yield return new KV("named", (StatelessFactoryDelegate)Create_49);
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_50);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_51);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_52);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.AppleFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_53);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler))
            {
                yield return new KV(DryIoc.MefAttributedModel.UnitTests.CUT.BlahFooh.Fooh, (StatelessFactoryDelegate)Create_54);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_55);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ISomeDb))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_56);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooHey))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_57);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_58);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler))
            {
                yield return new KV("transact", (StatelessFactoryDelegate)Create_59);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_60);
            }

            if (serviceType == typeof(System.Func<string, DryIoc.MefAttributedModel.UnitTests.CUT.Orange>))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_61);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_62);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_63);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService))
            {
                yield return new KV(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceKey.OtherOne, (StatelessFactoryDelegate)Create_64);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_65);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumer))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_66);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.INamedService))
            {
                yield return new KV("blah", (StatelessFactoryDelegate)Create_67);
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_68);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IForExport))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_69);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_70);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DependentService))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_71);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_72);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IPrintToCode))
            {
                yield return new KV(1, (StatelessFactoryDelegate)Create_73);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Chicken))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_74);
                yield return new KV(DefaultKey.Of(1), (StatelessFactoryDelegate)Create_75);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_76);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne))
            {
                yield return new KV("blah", (StatelessFactoryDelegate)Create_77);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_78);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IAnotherDb))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_79);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_80);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Service))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_81);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_82);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.DbMan))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_83);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler))
            {
                yield return new KV("slow", (StatelessFactoryDelegate)Create_84);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_85);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Duck))
            {
                yield return new KV(DefaultKey.Of(0), (StatelessFactoryDelegate)Create_86);
                yield return new KV(DefaultKey.Of(1), (StatelessFactoryDelegate)Create_87);
            }

            if (serviceType == typeof(DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructorsAndOneImporting))
            {
                yield return new KV(null, (StatelessFactoryDelegate)Create_88);
            }

        }

        internal static object Create_1(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(98, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithFieldAndProperty { Property = (DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService)r.Scopes.SingletonScope.GetOrAdd(109, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService()), Field = (DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService)r.Scopes.SingletonScope.GetOrAdd(109, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService()) });
        }

        internal static object Create_2(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(107, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ForExportBaseImpl());
        }

        internal static object Create_3(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(99, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OneDependsOnExternalTool((DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool)r.Scopes.SingletonScope.GetOrAdd(110, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool())));
        }

        internal static object Create_4(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(65, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FactoryConsumer(new DryIoc.MefAttributedModel.UnitTests.CUT.IFactory<DryIoc.MefAttributedModel.UnitTests.CUT.One>[] { (DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<DryIoc.MefAttributedModel.UnitTests.CUT.One>)r.Scopes.SingletonScope.GetOrAdd(111, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<DryIoc.MefAttributedModel.UnitTests.CUT.One>(() => (DryIoc.MefAttributedModel.UnitTests.CUT.One)r.Scopes.SingletonScope.GetOrAdd(66, () => new DryIoc.MefAttributedModel.UnitTests.CUT.One()))), (DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<DryIoc.MefAttributedModel.UnitTests.CUT.One>)r.Scopes.SingletonScope.GetOrAdd(112, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DryFactory<DryIoc.MefAttributedModel.UnitTests.CUT.One>(() => (DryIoc.MefAttributedModel.UnitTests.CUT.One)r.Scopes.SingletonScope.GetOrAdd(66, () => new DryIoc.MefAttributedModel.UnitTests.CUT.One()))) }));
        }

        internal static object Create_5(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(17, () => new DryIoc.MefAttributedModel.UnitTests.CUT.Service());
        }

        internal static object Create_6(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(90, () => new DryIoc.MefAttributedModel.UnitTests.CUT.KeyService());
        }

        internal static object Create_7(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(18, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService());
        }

        internal static object Create_8(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(91, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService());
        }

        internal static object Create_9(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(77, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory());
        }

        internal static object Create_10(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.Me();
        }

        internal static object Create_11(IResolverContext r, IScope scope)
        {
            return new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_2_IHandler0 => new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_4_IHandler0 => new DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport(_4_IHandler0))(new DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandlerDecorator(_2_IHandler0)))((DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler)r.Scopes.SingletonScope.GetOrAdd(53, () => new DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler()));
        }

        internal static object Create_12(IResolverContext r, IScope scope)
        {
            return new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_0_IHandler0 => new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_4_IHandler0 => new DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport(_4_IHandler0))(new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_3_IHandler0 => new DryIoc.MefAttributedModel.UnitTests.CUT.CustomHandlerDecorator(_3_IHandler0))(new DryIoc.MefAttributedModel.UnitTests.CUT.LoggingHandlerDecorator(_0_IHandler0))))((DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler)r.Scopes.SingletonScope.GetOrAdd(52, () => new DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler()));
        }

        internal static object Create_13(IResolverContext r, IScope scope)
        {
            return new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_1_IHandler0 => new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_4_IHandler0 => new DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport(_4_IHandler0))(new DryIoc.MefAttributedModel.UnitTests.CUT.RetryHandlerDecorator(_1_IHandler0)))((DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler)r.Scopes.SingletonScope.GetOrAdd(51, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler()));
        }

        internal static object Create_14(IResolverContext r, IScope scope)
        {
            return new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_4_IHandler0 => new DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport(_4_IHandler0))((DryIoc.MefAttributedModel.UnitTests.CUT.BlahHandler)r.Scopes.SingletonScope.GetOrAdd(59, () => new DryIoc.MefAttributedModel.UnitTests.CUT.BlahHandler()));
        }

        internal static object Create_15(IResolverContext r, IScope scope)
        {
            return new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_4_IHandler0 => new System.Func<DryIoc.MefAttributedModel.UnitTests.CUT.IHandler, DryIoc.MefAttributedModel.UnitTests.CUT.IHandler>(_5_IHandler0 => new DryIoc.MefAttributedModel.UnitTests.CUT.FoohDecorator(_5_IHandler0))(new DryIoc.MefAttributedModel.UnitTests.CUT.DecoratorWithFastHandlerImport(_4_IHandler0)))((DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler)r.Scopes.SingletonScope.GetOrAdd(60, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler()));
        }

        internal static object Create_16(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(102, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FooHey());
        }

        internal static object Create_17(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(103, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah());
        }

        internal static object Create_18(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep();
        }

        internal static object Create_19(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(108, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_20(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(108, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_21(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(108, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_22(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(27, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OneServiceWithMetadata());
        }

        internal static object Create_23(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherServiceWithMetadata();
        }

        internal static object Create_24(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.YetAnotherServiceWithMetadata();
        }

        internal static object Create_25(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.NativeUser(new DryIoc.MefAttributedModel.UnitTests.CUT.ForeignTool());
        }

        internal static object Create_26(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(51, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FastHandler());
        }

        internal static object Create_27(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(108, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_28(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(108, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_29(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(108, () => new DryIoc.MefAttributedModel.UnitTests.CUT.MultiExported());
        }

        internal static object Create_30(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(94, () => new DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport());
        }

        internal static object Create_31(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(93, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne());
        }

        internal static object Create_32(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(94, () => new DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport());
        }

        internal static object Create_33(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.TransientService();
        }

        internal static object Create_34(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(82, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory());
        }

        internal static object Create_35(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(20, () => new DryIoc.MefAttributedModel.UnitTests.CUT.SingletonService());
        }

        internal static object Create_36(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(73, () => ((DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory)r.Scopes.SingletonScope.GetOrAdd(72, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory())).Create());
        }

        internal static object Create_37(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(75, () => ((DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory)r.Scopes.SingletonScope.GetOrAdd(74, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory())).CreateOrange());
        }

        internal static object Create_38(IResolverContext r, IScope scope)
        {
            return ((DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory)r.Scopes.SingletonScope.GetOrAdd(80, () => new DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory())).Create();
        }

        internal static object Create_39(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(78, () => ((DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory)r.Scopes.SingletonScope.GetOrAdd(77, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory())).CreateOrange());
        }

        internal static object Create_40(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(48, () => new DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample());
        }

        internal static object Create_41(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(92, () => new DryIoc.MefAttributedModel.UnitTests.CUT.WithBothTheSameExports());
        }

        internal static object Create_42(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(100, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OtherDependsOnExternalTool((DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool)r.Scopes.SingletonScope.GetOrAdd(110, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ExternalTool())));
        }

        internal static object Create_43(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(66, () => new DryIoc.MefAttributedModel.UnitTests.CUT.One());
        }

        internal static object Create_44(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(66, () => new DryIoc.MefAttributedModel.UnitTests.CUT.One());
        }

        internal static object Create_45(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(46, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject2((DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2)r.Scopes.SingletonScope.GetOrAdd(43, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject2())));
        }

        internal static object Create_46(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(76, () => ((DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory)r.Scopes.SingletonScope.GetOrAdd(74, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory())).CreateApple());
        }

        internal static object Create_47(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(79, () => ((DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory)r.Scopes.SingletonScope.GetOrAdd(77, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedFruitFactory())).CreateApple());
        }

        internal static object Create_48(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(93, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne());
        }

        internal static object Create_49(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(94, () => new DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport());
        }

        internal static object Create_50(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(94, () => new DryIoc.MefAttributedModel.UnitTests.CUT.BothExportManyAndExport());
        }

        internal static object Create_51(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(18, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherService());
        }

        internal static object Create_52(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(80, () => new DryIoc.MefAttributedModel.UnitTests.CUT.TransientOrangeFactory());
        }

        internal static object Create_53(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(71, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AppleFactory());
        }

        internal static object Create_54(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(60, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FoohHandler());
        }

        internal static object Create_55(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(33, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithImportedCtorParameter((DryIoc.MefAttributedModel.UnitTests.CUT.AnotherNamedService)r.Scopes.SingletonScope.GetOrAdd(35, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherNamedService())));
        }

        internal static object Create_56(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(36, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DbMan());
        }

        internal static object Create_57(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(102, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FooHey());
        }

        internal static object Create_58(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(50, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ClientWithServiceAndPrimitiveProperty { Service = (DryIoc.MefAttributedModel.UnitTests.CUT.KeyService)r.Scopes.SingletonScope.GetOrAdd(90, () => new DryIoc.MefAttributedModel.UnitTests.CUT.KeyService()) });
        }

        internal static object Create_59(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(53, () => new DryIoc.MefAttributedModel.UnitTests.CUT.TransactHandler());
        }

        internal static object Create_60(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(72, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OrangeFactory());
        }

        internal static object Create_61(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(83, () => ((DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory)r.Scopes.SingletonScope.GetOrAdd(82, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FuncFactory())).Create());
        }

        internal static object Create_62(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.LazyDecorator(new System.Lazy<DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult>(() => (DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult)r.Resolver.ResolveKeyed(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), (object)null, DryIoc.IfUnresolved.Throw, (System.Type)null, r.Scopes.GetOrCreateResolutionScope(ref scope, typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IDecoratedResult), (object)null))));
        }

        internal static object Create_63(IResolverContext r, IScope scope)
        {
            return new DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient((DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep)r.Resolver.ResolveKeyed(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDep), (object)null, DryIoc.IfUnresolved.Throw, (System.Type)null, r.Scopes.GetOrCreateResolutionScope(ref scope, typeof(DryIoc.MefAttributedModel.UnitTests.CUT.LazyDepClient), (object)null)));
        }

        internal static object Create_64(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(91, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OtherKeyService());
        }

        internal static object Create_65(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(45, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject1((DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject)r.Scopes.SingletonScope.GetOrAdd(42, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject())));
        }

        internal static object Create_66(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(104, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumer(new System.Lazy<DryIoc.MefAttributedModel.UnitTests.CUT.IFooService>(() => (DryIoc.MefAttributedModel.UnitTests.CUT.IFooService)r.Resolver.ResolveKeyed(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.IFooService), (object)DryIoc.DefaultKey.Of(1), DryIoc.IfUnresolved.Throw, (System.Type)null, r.Scopes.GetOrCreateResolutionScope(ref scope, typeof(DryIoc.MefAttributedModel.UnitTests.CUT.FooConsumer), (object)null)))));
        }

        internal static object Create_67(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(35, () => new DryIoc.MefAttributedModel.UnitTests.CUT.AnotherNamedService());
        }

        internal static object Create_68(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(34, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedService());
        }

        internal static object Create_69(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(106, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ForExport());
        }

        internal static object Create_70(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(38, () => new DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable(new DryIoc.LazyEnumerable<DryIoc.MefAttributedModel.UnitTests.CUT.Me>(r.Resolver.ResolveMany(typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me), null, typeof(DryIoc.MefAttributedModel.UnitTests.CUT.Me), null, r.Scopes.GetOrCreateResolutionScope(ref scope, typeof(DryIoc.MefAttributedModel.UnitTests.CUT.UseLazyEnumerable), (object)null)).Cast<DryIoc.MefAttributedModel.UnitTests.CUT.Me>())));
        }

        internal static object Create_71(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(24, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DependentService(new DryIoc.MefAttributedModel.UnitTests.CUT.TransientService(), (DryIoc.MefAttributedModel.UnitTests.CUT.SingletonService)r.Scopes.SingletonScope.GetOrAdd(20, () => new DryIoc.MefAttributedModel.UnitTests.CUT.SingletonService()), new DryIoc.MefAttributedModel.UnitTests.CUT.TransientOpenGenericService<string>(), (DryIoc.MefAttributedModel.UnitTests.CUT.OpenGenericServiceWithTwoParameters<bool, bool>)r.Scopes.SingletonScope.GetOrAdd(115, () => new DryIoc.MefAttributedModel.UnitTests.CUT.OpenGenericServiceWithTwoParameters<bool, bool>())));
        }

        internal static object Create_72(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(74, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FruitFactory());
        }

        internal static object Create_73(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(48, () => new DryIoc.MefAttributedModel.UnitTests.CUT.PrintToCodeExample());
        }

        internal static object Create_74(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(86, () => DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory.Chicken);
        }

        internal static object Create_75(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(87, () => DryIoc.MefAttributedModel.UnitTests.CUT.StaticBirdFactory.Chicken);
        }

        internal static object Create_76(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(84, () => new DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory());
        }

        internal static object Create_77(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(93, () => new DryIoc.MefAttributedModel.UnitTests.CUT.NamedOne());
        }

        internal static object Create_78(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(32, () => new DryIoc.MefAttributedModel.UnitTests.CUT.SingleServiceWithMetadata());
        }

        internal static object Create_79(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(36, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DbMan());
        }

        internal static object Create_80(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(89, () => new DryIoc.MefAttributedModel.UnitTests.CUT.KeyClient((DryIoc.MefAttributedModel.UnitTests.CUT.KeyService)r.Scopes.SingletonScope.GetOrAdd(90, () => new DryIoc.MefAttributedModel.UnitTests.CUT.KeyService())));
        }

        internal static object Create_81(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(17, () => new DryIoc.MefAttributedModel.UnitTests.CUT.Service());
        }

        internal static object Create_82(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(47, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ImportConditionObject3((DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3)r.Scopes.SingletonScope.GetOrAdd(44, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ExportConditionalObject3())));
        }

        internal static object Create_83(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(36, () => new DryIoc.MefAttributedModel.UnitTests.CUT.DbMan());
        }

        internal static object Create_84(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(52, () => new DryIoc.MefAttributedModel.UnitTests.CUT.SlowHandler());
        }

        internal static object Create_85(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(103, () => new DryIoc.MefAttributedModel.UnitTests.CUT.FooBlah());
        }

        internal static object Create_86(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(85, () => DryIoc.MefAttributedModel.UnitTests.CUT.BirdFactory.GetDuck());
        }

        internal static object Create_87(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(88, () => DryIoc.MefAttributedModel.UnitTests.CUT.StaticBirdFactory.Duck);
        }

        internal static object Create_88(IResolverContext r, IScope scope)
        {
            return r.Scopes.SingletonScope.GetOrAdd(31, () => new DryIoc.MefAttributedModel.UnitTests.CUT.ServiceWithMultipleCostructorsAndOneImporting(new DryIoc.MefAttributedModel.UnitTests.CUT.TransientService()));
        }

    }
}